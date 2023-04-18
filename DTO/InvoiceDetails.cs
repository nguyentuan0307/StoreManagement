namespace ComputerRepair.DTO
{
    public class InvoiceDetails
    {
        public string CustomerID { get; set; }
        public List<ServiceAndDeviceViewModel> serviceAndDevices { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
