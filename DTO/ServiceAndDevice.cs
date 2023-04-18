namespace ComputerRepair.DTO
{
    public class ServiceAndDevice
    {
        public int ServiceID { get; set; }
        public String? ServiceName { get; set; }
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
