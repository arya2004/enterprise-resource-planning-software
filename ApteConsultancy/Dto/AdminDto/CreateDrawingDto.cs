using ApteConsultancy.Models.Master;
using ApteConsultancy.Models;

namespace ApteConsultancy.Dto.AdminDto
{
    public class CreateDrawingDto
    {
        public int? ProjectId { get; set; }
        public int? CompanyId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ClientId { get; set; }
        public int? ArchitectId { get; set; }
        public int DrawingNumber { get; set; }
    }
}
