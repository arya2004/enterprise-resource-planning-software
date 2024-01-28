using ApteConsultancy.Model.Master;
using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Models
{
    public class EmployeeTimeSheet
    {
        public int EmployeeTimeSheetId { get; set; }
        public ApplicationUser? Employee { get; set; }
        public Project? Project { get; set; }
        public DateTime? WorkDate { get; set; }
        public required string WorkDescription { get; set; }
        public required decimal HoursSpent { get; set; }
        public decimal RatePerHour { get; set; }
        public decimal Amount => HoursSpent * RatePerHour;
    }
}
