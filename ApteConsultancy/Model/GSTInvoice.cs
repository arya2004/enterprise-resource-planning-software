using ApteConsultancy.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApteConsultancy.Models
{
    public class GSTInvoice
    {
        public int GSTInvoiceId { get; set; }
        public Project? Project { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public double Amount { get; set; }
        public double IGST => Amount * 0.18;
        public double SGST => Amount * 0.09;
        public double CGST => Amount * 0.09;
        public double NetAmount => Amount + IGST;
    }
}
