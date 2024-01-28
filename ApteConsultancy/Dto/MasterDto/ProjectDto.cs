using ApteConsultancy.Model.Master;
using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Dto.MasterDto
{
    public class ProjectDto
    {
     
        public int? CompanyId { get; set; }
        public ICollection<string>?  AssociateAndEmployees { get; set; }
        public int? ClientId { get; set; }
        public int? ArchitectId { get; set; }
       

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
