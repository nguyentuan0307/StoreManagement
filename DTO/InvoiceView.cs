namespace ComputerRepair.DTO
{
    public class InvoiceView
    {
        public int InvoiceID { get; set; }
        public String CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
