using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Dto.EmployeeDto
{
    public class CreateAttendanceDto
    {
        public DateTime Date { get; set; }
        public string? Attendance_Type { get; set; }
    }
}
