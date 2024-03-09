namespace ApteConsultancy.Dto.MasterDto
{
    public class CompanyDto
    {

        public int? CompanyId { get; set; }
        public string? CompanyCode { get; set; }
        public string? Name { get; set; }
        public string? DirectorName { get; set; }
        public int DirectorEmployeeCode { get; set; }
        public int DirectorMobile { get; set; }
        public int LandLine { get; set; }
        public string? DirectorEmail { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostalCode { get; set; }
        public string? PanNumber { get; set; }
    }
}
