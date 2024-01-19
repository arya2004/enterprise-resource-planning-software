using ApteConsultancy.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApteConsultancy.Models
{
    public class Employee_Attendance
    {
        public int Employee_AttendanceId { get; set; }
        public EmployeeUser  Employee { get; set; }
        public DateTime Date { get; set; }
        public string Attendance_Type { get; set; }
    }
}
