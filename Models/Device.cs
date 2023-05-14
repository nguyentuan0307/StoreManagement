namespace ComputerRepair.Models
{
    public class Device
    {
        public Device()
        {
            Requests = new HashSet<Requestx> { };
        }
        public int DeviceID { get; set; }
        public string? DeviceName { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public int WarrantyPeriod { get; set; }
        public int Quantity { get; set; }
        public HashSet<Requestx> Requests { get; set; }
    }
}
