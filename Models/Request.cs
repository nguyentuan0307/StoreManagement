namespace ComputerRepair.Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public int DeviceServiceID { get; set; }
        public int InvoiceID { get; set; }
        public int Quantity { get; set; }
        public DeviceService? DeviceService { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
