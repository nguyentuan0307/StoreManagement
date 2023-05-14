namespace ComputerRepair.DTO
{
    public class DeviceView
    {
        public int DeviceID { get; set; }
        public string? DeviceName { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public int WarrantyPeriod { get; set; }
        public int Quantity { get; set; }
    }
}
