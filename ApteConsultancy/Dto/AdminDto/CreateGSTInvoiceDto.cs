namespace ApteConsultancy.Dto.AdminDto
{
    public class CreateGSTInvoiceDto
    {
        public int? ProjectId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public double Amount { get; set; }
  
    }
}
