using ApteConsultancy.Model.Master;

namespace ApteConsultancy.Dto.EmployeeDto
{
    public class CreateOwnCarLocalAndOutStationDto
    {
     
        public int? ProjectId { get; set; }
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
