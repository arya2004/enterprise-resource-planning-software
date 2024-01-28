namespace ApteConsultancy.Dto.AdminDto
{
    public class CreateProformaInvoiceDto
    {
        public int? ProjectId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public double Amount { get; set; }
        public string GST_Invoice_Status { get; set; }
        public DateTime GST_Invoice_Date { get; set; }
        public string GST_Invoice_Number { get; set; }
    }
}
