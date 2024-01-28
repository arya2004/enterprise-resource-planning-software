namespace ApteConsultancy.Dto.AdminDto
{
    public class CreateProjectFeesDto
    { 
        public int? ProjectId { get; set; }
        public DateTime TRXDate { get; set; }
        public DateTime ValueDate { get; set; }
        public string? TRXno { get; set; }
        public double Amount { get; set; }
        public double TDSAmount { get; set; }
    
    }
}
