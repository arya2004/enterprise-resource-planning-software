using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Models
{
    public class EmployeeTimeSheet
    {
        public int EmployeeTimeSheetId { get; set; }
        public EmployeeUser? Employee { get; set; }
        public Project? Project { get; set; }
        public DateTime? WorkDate { get; set; }
        public required string WorkDescription { get; set; }
        public required decimal HoursSpent { get; set; }
        public decimal RatePerHour { get; set; }
        public decimal Amount => HoursSpent * RatePerHour;
    }
}
