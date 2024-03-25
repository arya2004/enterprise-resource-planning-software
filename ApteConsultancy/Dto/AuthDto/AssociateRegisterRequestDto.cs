namespace ApteConsultancy.Dto.AuthDto
{
    public class AssociateRegisterRequestDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }

        public string? CompanyName { get; set; }


        public string? Designation1 { get; set; }

        public string? Email1 { get; set; }

        public string? Designation2 { get; set; }

        public string? Email2 { get; set; }
        public string? PanNumber { get; set; }
        public string? GstNUmber { get; set; }
        public string? Bank { get; set; }


        public bool IsFreeLancer { get; set; }
        public string? BranchName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostalCode { get; set; }
        public string? ContactPerson1 { get; set; }
        public int MobileNumber1 { get; set; }
        public string? ContactPerson2 { get; set; }
        public int MobileNumber2 { get; set; }
        public string? BranchAddress { get; set; }
        public int AccountNumber { get; set; }
        public string? ISFCode { get; set; }
        public int AccountType { get; set; }
    }
}
