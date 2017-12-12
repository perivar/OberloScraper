using System;
using System.Globalization;

namespace OberloScraper
{
    public class OberloOrder
    {
        public string OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FinancialStatus { get; set; }
        public string FulfillmentStatus { get; set; }
        public string Supplier { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Variant { get; set; }
        public int Quantity { get; set; }
        public string TrackingNumber { get; set; }
        public string AliOrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZip { get; set; }
        public string OrderNote { get; set; }
        public string OrderState { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1:yyyy-MM-dd} {2} {3} {4} x {5} {6}", OrderNumber, CreatedDate, AliOrderNumber, SKU, CustomerName, Quantity, Cost.ToString("C", new CultureInfo("en-US")));
        }
    }
}
