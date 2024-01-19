using System.ComponentModel.DataAnnotations;

namespace ApteConsultancy.Models.Master
{
    public class Project
    {
        [Key]
        public string? ProjectId { get; set; } = Guid.NewGuid().ToString();
        public Company?  Company { get; set; }
        public EmployeeUser? Employee { get; set; }
        public Client? Client { get; set; }
        public Architect? Architect { get; set; }
        public AssociateUser? Associate { get; set; }

        public int? ProjectCode { get; set; }
        public string? Name { get; set; }
        public string? ClientWoNumber { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? Services { get; set; }
        public string? ProjecLocation { get; set; }
        public decimal? TotalFees { get; set; }
        public decimal? FeesReceived { get; set; }
        public decimal? FeesBalance { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? ProfitAmount { get; set; }
        public bool? IsCompleted { get; set; } 


    }
}
