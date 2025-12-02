using ERP_System.BL;
using ERP_System.DL;
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
    public partial class AddSaleForm : Form
    {
        private readonly ProductBL _productBL;
        private readonly SaleBL _salesBL;
        private readonly UserBL _userBL;
        private readonly TransHistBL _transBL;
        private readonly GmailEmailService _emailBL;
        public AddSaleForm()
        {
            InitializeComponent();
            _productBL = new ProductBL();
            _salesBL = new SaleBL();
            _userBL = new UserBL();
            _transBL = new TransHistBL();
            _emailBL = new GmailEmailService();

           

            // initialize
            LoadProductsForCards();
            ResetTotals();
        }

        private DataTable _productsTable;

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

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            AddNewItemCard();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
        }

        private void AddNewItemCard()
        {
            var card = new SalesAddProductCard();
            card.InitializeProducts(_productsTable);
            card.RemoveRequested += Card_RemoveRequested;

            
            card.Quantity = 1;

           
            flowLayoutPanel1.Controls.Add(card);
           

           
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
            decimal subtotal = 0m;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is SalesAddProductCard card)
                {
                    subtotal += card.LineTotal;
                }
            }

            lblSubtotal.Text = subtotal.ToString("C2", CultureInfo.CurrentCulture);

            // parse tax percent from lblTaxPer (e.g., "5%")
            decimal taxPercent = 0m;
            var taxText = lblTaxPer.Text?.Replace("%", "").Trim();
            if (decimal.TryParse(taxText, NumberStyles.Number, CultureInfo.InvariantCulture, out var tp))
                taxPercent = tp;

            decimal taxAmount = Math.Round(subtotal * taxPercent / 100m, 2);
            lblTax.Text = taxAmount.ToString("C2", CultureInfo.CurrentCulture);

            decimal total = subtotal + taxAmount;
            lblTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void ResetTotals()
        {
            lblSubtotal.Text = 0m.ToString("C2");
            lblTax.Text = 0m.ToString("C2");
            lblTotal.Text = 0m.ToString("C2");
            lblTaxPer.Text = "0%";
        }

       

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var items = CollectLineItems();
                if (items.Count == 0)
                {
                    MessageBox.Show("Add at least one item.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal subtotal = items.Sum(i => i.lineTotal);
                decimal taxPercent = ParseTaxPercent();
                decimal taxAmount = Math.Round(subtotal * taxPercent / 100m, 2);
                decimal total = subtotal + taxAmount;

                // Build SaleDTO
                var sale = new SaleDTO
                {
                    CustomerName = lblCusName.Text?.Trim(),
                    Date = DateTime.Now,
                    TotalAmount = total,
                    Status = "paid",
                    UserId = _userBL.GetCurrentUserId(),
                };

                foreach (var it in items)
                {
                    sale.Items.Add(new SaleItemDTO
                    {   
                        ProductId = it.productId,
                      
                        Quantity = it.qty,
                        UnitPrice = it.unitPrice,
                        TotalPrice = it.lineTotal
                    });
                }


                // Persist via BL (this will validate stock and update it inside a transaction)
                int newSaleId = _salesBL.AddSale(sale);
                var transDTO= new TransHistDTO { 
                    ReferenceId = newSaleId,
                    TransactionType="Sale",
                    Amount=sale.TotalAmount,
                    Status="Paid",
                    PerformedBy=sale.UserId,
                    PerformedByName=_userBL.GetCurrentUser().Name


                };

              

                _transBL.AddTransaction(transDTO);


                List<ProductDTO> lowStockProd = new List<ProductDTO>();
                foreach (var item in sale.Items) {
                    
                    ProductDTO p = _productBL.GetProduct(item.ProductId);
                    p.Stock -= item.Quantity;
                    _productBL.UpdateProduct(p);
                    if (p.Stock <= p.LowStockThreshold) { 
                    lowStockProd.Add(p);
                    }
                    
                }
                if(lowStockProd.Count>0)
                await _emailBL.SendLowStockAlertAsync(lowStockProd);

                MessageBox.Show($"Sale saved (ID: {newSaleId}).\nTotal: {total:C2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                this.Hide();
            }
            catch (InvalidOperationException invEx)
            {
                // Stock validation or other domain error from DL
                MessageBox.Show(invEx.Message, "Stock validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            try
            {
                var items = CollectLineItems();
                if (items.Count == 0)
                {
                    MessageBox.Show("Add at least one item to save draft.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal subtotal = items.Sum(i => i.lineTotal);
                decimal taxPercent = ParseTaxPercent();
                decimal taxAmount = Math.Round(subtotal * taxPercent / 100m, 2);
                decimal total = subtotal + taxAmount;

                var draft = new SaleDTO
                {
                    CustomerName = txtlName.Text?.Trim(),
                    Date = DateTime.Now,
                   
                    TotalAmount = total,
                    Status = "draft",
                    UserId = _userBL.GetCurrentUserId()
                };

                foreach (var it in items)
                {
                    draft.Items.Add(new SaleItemDTO
                    {
                        ProductId = it.productId,
                        Quantity = it.qty,
                        UnitPrice = it.unitPrice,
                        TotalPrice = it.lineTotal
                    });
                }

                int draftId = _salesBL.AddSale(draft);

                int newSaleId = _salesBL.AddSale(draft);
                var transDTO = new TransHistDTO
                {
                    ReferenceId = newSaleId,
                    TransactionType = "Sale",
                    Amount = draft.TotalAmount,
                    Status = "Draft",
                    PerformedBy = draft.UserId,
                    PerformedByName = _userBL.GetCurrentUser().Name


                };
                _transBL.AddTransaction(transDTO);

                MessageBox.Show($"Draft saved (ID: {draftId}).", "Draft Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                this.Hide();
            }
            catch (InvalidOperationException invEx)
            {
              
                MessageBox.Show(invEx.Message, "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save draft: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearForm()
        {
            
            foreach (Control c in flowLayoutPanel1.Controls.OfType<SalesAddProductCard>().ToList())
            {
                flowLayoutPanel1.Controls.Remove(c);
                c.Dispose();
            }

          
            ResetTotals();
            lblCusName.Text = "CustomerName";
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
          
        }
        private decimal ParseTaxPercent()
        {
            var taxText = lblTaxPer.Text?.Replace("%", "").Trim();
            if (decimal.TryParse(taxText, NumberStyles.Number, CultureInfo.InvariantCulture, out var tp))
                return tp;
            return 0m;
        }
    }
}
