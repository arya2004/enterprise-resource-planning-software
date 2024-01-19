using Microsoft.AspNetCore.Identity;

namespace ApteConsultancy.Models.Master
{
    public class EmployeeUser : IdentityUser
    {
        public string? EmployeeCode { get; set; } 
        public string? EmployeeName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostalCode { get; set; }
        public string? ContactPerson1 { get; set; }
        public string? Relation1 { get; set; }
        public int MobileNumber1 { get; set; }
        public string? ContactPerson2 { get; set; }
        public string? Relation2 { get; set; }
        public int MobileNumber2 { get; set; }
        public int ExpBeforeJoiningY { get; set; }
        public int ExpBeforeJoiningM { get; set; }
        public string? Pan { get; set; }
        public string? UID { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Anniversary { get; set; }
        public string? BankName { get; set; }
        public string? BranchNam { get; set; }
        public string? BranchAddress { get; set; }
        public int AccountNumber { get; set; }
        public string? ISFCode { get; set; }
        public string? AccountType { get; set; }
        public int MonthlySalary { get; set; }




    }
}
