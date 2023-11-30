namespace api_web_inventory.Models
{
    public class InventoryTransaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public string TransactionType { get; set; } // Consider using an enum here
        public int Quantity { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
