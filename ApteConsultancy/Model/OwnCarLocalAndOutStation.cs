using ApteConsultancy.Models.Master;

namespace ApteConsultancy.Models
{
    public class OwnCarLocalAndOutStation
    {
        public int OwnCarLocalAndOutStationId { get; set; }
        public Project? Project { get; set; }
        public EmployeeUser? Employee { get; set; }
        public decimal PetrolRate { get; set; }
        public decimal CarAvgKMPL { get; set; }
        public decimal DistanceTravelled { get; set; }
        public decimal CostOfTravel { get; set; }
        public decimal? PublicTransport { get; set; }
        public decimal? DrawingPrints { get; set; }
        public decimal? Courier { get; set; }
        public decimal? Toll { get; set; }
    }
}
