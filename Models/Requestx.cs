namespace ComputerRepair.Models
{
    public class Requestx
    {
        public int RequestxID { get; set; }
        public int ServiceID { get; set; }
        public Service? Service { get; set; }
        public int DeviceID { get; set; }
        public Device? Device { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int InvoiceID { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
