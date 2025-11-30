using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class LowStockCard : UserControl
    {
        // Default constructor
        public LowStockCard()
        {
            InitializeComponent();
        }

        // Parameterized constructor: build card from product info
        public LowStockCard(string code, string name, int currentStock, int threshold)
        {
            InitializeComponent();
            itmCode.Text = code;
            itmName.Text = name;
            lblCurrStk.Text = $"Current: {currentStock} units";
            lblThres.Text = $"Reorder at: {threshold} units";
        }

      
        public LowStockCard(ProductDTO dto)
        {
            InitializeComponent();
            itmCode.Text = string.IsNullOrWhiteSpace(dto.SKU) ? $"ID-{dto.Id}" : dto.SKU;
            itmName.Text = dto.Name;
            lblCurrStk.Text = $"Current: {dto.Stock} units";
            lblThres.Text = $"Reorder at: {dto.LowStockThreshold} units";
        }

       
        public static List<LowStockCard> CreateCardsFromProducts(IEnumerable<ProductDTO> products)
        {
            var cards = new List<LowStockCard>();
            foreach (var p in products)
            {
                // Only include low stock items
                if (p.Stock <= p.LowStockThreshold)
                {
                    cards.Add(new LowStockCard(p));
                }
            }
            return cards;
        }
    }
}
