using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEntityFramework
{
    class InvoiceLines
    {
        public int InvoiceLineID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal LineProfit { get; set; }
        public decimal ExtendedPrice { get; set; }

        public InvoiceLines(int invoiceLines, string description, int quantity, decimal unitPrice, decimal taxRate, decimal taxAmount, decimal lineProfit, decimal extendedPrice)
        {
            InvoiceLineID = invoiceLines;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TaxRate = taxRate;
            TaxAmount = taxAmount;
            LineProfit = lineProfit;
            ExtendedPrice = extendedPrice;
        }
    }
}
