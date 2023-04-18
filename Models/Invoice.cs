namespace ComputerRepair.Models
{
    public class Invoice
    {
        public Invoice()
        {
            Requests = new HashSet<Requestx>();
        }
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Customer? Customer { get; set; }
        public HashSet<Requestx> Requests { get; set; }
    }
}
