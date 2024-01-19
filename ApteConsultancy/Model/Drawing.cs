using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Models
{
    public class Drawing
    {
        public int DrawingId { get; set; }
        public Project?  Project { get; set; }
        public Company? Company { get; set; }
        public EmployeeUser? Employee { get; set; }
        public Client? Client { get; set; }
        public Architect? Architect { get; set; }
        public int DrawingNumber { get; set; }
        public ICollection<DrawingRevision>? DrawingRevisions { get; set; }
        

    }
}
