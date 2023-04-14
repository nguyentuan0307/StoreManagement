namespace ComputerRepair.Models
{
    public class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public HashSet<Invoice> Invoices { get; set; }
    }
}
