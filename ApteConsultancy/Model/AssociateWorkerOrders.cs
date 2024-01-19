using ApteConsultancy.Models.Master;

namespace ApteConsultancyWEB.Models
{
    public class AssociateWorkerOrders
    {
        public int AssociateWorkerOrdersId { get; set; }
        public Project? Project { get; set; }
        public AssociateUser? AssociateUser { get; set; }
        public string? WorkOrderNumber { get; set; }
        public decimal? WoAmmount { get; set; }
        public string? Service { get; set; }
        public DateTime? WoDate { get; set; }
        public string? WoStatus { get; set; }
    }


}
