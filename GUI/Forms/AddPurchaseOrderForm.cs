using ERP_System.BL;
using ERP_System.DTO;
using ERP_System.GUI.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ERP_System.GUI.Forms
{
    public partial class AddPurchaseOrderForm : Form
    {
        private readonly ProductBL _productBL;
        private readonly PurchaseBL _purchaseBL;
        private readonly UserBL _userBL;
        private readonly TransHistBL _transBL;
        private readonly SupplierBL _supplierBL;
        private DataTable _productsTable;

        public AddPurchaseOrderForm()
        {
            InitializeComponent();

            _productBL = new ProductBL();
            _purchaseBL = new PurchaseBL();
            _userBL = new UserBL();
            _transBL = new TransHistBL();
            _supplierBL=new SupplierBL();


            // wire events
            btnAddItem.Click += BtnAddItem_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnSearch.Click += BtnSearch_Click;

            // initial load
            LoadProductsForCards();
            ResetTotals();
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bunifuDatePicker1.Value = DateTime.Now;
        }

        private void LoadProductsForCards()
        {
            try
            {
                _productsTable = _productBL.GetAllProducts();
            }
            catch
            {
                _productsTable = new DataTable();
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e) => AddNewItemCard();

        private void AddNewItemCard()
        {
            var card = new SalesAddProductCard(); // reuse the same card component
            card.InitializeProducts(_productsTable);
            card.RemoveRequested += Card_RemoveRequested;
            card.Quantity = 1;

            flowLayoutPanel1.Controls.Add(card);

            // recalc totals when card changes
            card.txtQty.TextChanged += (s, e) => RecalculateTotals();
            card.txtunitPrice.TextChanged += (s, e) => RecalculateTotals();
            card.txtProd.SelectedIndexChanged += (s, e) => RecalculateTotals();

            RecalculateTotals();
        }

        private void Card_RemoveRequested(object sender, EventArgs e)
        {
            if (sender is SalesAddProductCard card)
            {
                flowLayoutPanel1.Controls.Remove(card);
                
                RecalculateTotals();
            }
        }

        private void RecalculateTotals()
        {
            decimal total = 0m;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is SalesAddProductCard card)
                {
                    total += card.LineTotal;
                }
            }

            lblTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void ResetTotals()
        {
            lblTotal.Text = 0m.ToString("C2");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
              
                var idText = txtSupID.Text?.Trim();
                if (string.IsNullOrEmpty(idText))
                {
                    MessageBox.Show("Please enter a Supplier ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupID.Focus();
                    return;
                }

                int.TryParse(idText, out int supplierId);
               

               
                var dto = _supplierBL.GetSupplier(supplierId);

                if (dto == null)
                {
                    MessageBox.Show($"No supplier found with ID {supplierId}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupName.Text = string.Empty;
                    txtSupID.Focus();
                    return;
                }

             
                txtSupName.Text = dto.Name ?? string.Empty;
                txtSupName.Focus();
            }
           
            catch (Exception ex)
            {
                
                MessageBox.Show("Failed to lookup supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<(int productId, string productName, int qty, decimal unitPrice, decimal lineTotal)> CollectLineItems()
        {
            var list = new List<(int, string, int, decimal, decimal)>();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is SalesAddProductCard card)
                {
                    var li = card.ToLineItem();
                    if (li.productId == 0)
                    {
                        MessageBox.Show("One or more items have no product selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return new List<(int, string, int, decimal, decimal)>();
                    }
                    if (li.qty <= 0)
                    {
                        MessageBox.Show("Quantity must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return new List<(int, string, int, decimal, decimal)>();
                    }
                    list.Add(li);
                }
            }
            return list;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var items = CollectLineItems();
                if (items.Count == 0)
                {
                    MessageBox.Show("Add at least one item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idText = txtSupID.Text?.Trim();
                if (string.IsNullOrEmpty(idText))
                {
                    MessageBox.Show("Please enter a Supplier ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupID.Focus();
                    return;
                }

                decimal total = items.Sum(i => i.lineTotal);

                // Build PurchaseDTO
                var purchase = new PurchaseDTO
                {
                    SupplierId = Convert.ToInt32(txtSupID.Text),
                    UserId = _userBL.GetCurrentUserId(),
                    Date = bunifuDatePicker1.Value.Date,
                    TotalAmount = total,
                    Notes = string.Empty
                };

                foreach (var it in items)
                {
                    purchase.Items.Add(new PurchaseItemDTO
                    {
                        ProductId = it.productId,
                        Quantity = it.qty,
                        UnitPrice = it.unitPrice,
                        TotalPrice = it.lineTotal
                    });
                }

                // Persist via BL (should insert purchase, insert items and increase stock inside a transaction)
                int newPurchaseId = _purchaseBL.AddPurchase(purchase);

                // record transaction history
                var transDTO = new TransHistDTO
                {
                    ReferenceId = newPurchaseId,
                    TransactionType = "Purchase",
                    Amount = purchase.TotalAmount,
                    Status = "Completed",
                    PerformedBy = purchase.UserId,
                    PerformedByName = _userBL.GetCurrentUser()?.Name,
                    PerformedAt = DateTime.UtcNow,
                    Notes = $"Purchase from supplier {txtSupName.Text}"
                };
                _transBL.AddTransaction(transDTO);

                foreach (var it in items)
                {   
                    ProductDTO p=_productBL.GetProduct(it.productId);
                    p.Stock += it.qty;
                    _productBL.UpdateProduct(p);
                }
                    MessageBox.Show($"Purchase saved (ID: {newPurchaseId}).\nTotal: {total:C2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                this.Hide();
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show(invEx.Message, "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       
        private void ClearForm()
        {
            foreach (Control c in flowLayoutPanel1.Controls.OfType<SalesAddProductCard>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(c);
                c.Dispose();
            }

            txtSupID.Text = string.Empty;
            txtSupName.Text = string.Empty;
            bunifuDatePicker1.Value = DateTime.Now;
            ResetTotals();
        }
    }
}
