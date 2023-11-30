namespace api_web_inventory.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int StockQuantity { get; set; }
        public string WarehouseLocation { get; set; }
    }

}
