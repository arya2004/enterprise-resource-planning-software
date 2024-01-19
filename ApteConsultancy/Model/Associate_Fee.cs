using ApteConsultancy.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApteConsultancy.Models
{
    public class Associate_Fee
    {
        public int Associate_FeeId { get; set; }
        public AssociateUser Associate { get; set; }
        public double Project_Fee { get; set; }
        public DateTime Transaction_Date { get; set; }
        public string Transaction_Type { get; set;}
        public double Amount { get; set; }
        public double TDSAmount { get; set; }
        public double IGST => Amount * 0.18;
        public double SGST => Amount * 0.09;
        public double CGST => Amount * 0.09;
        public double NetAmount => Amount - TDSAmount + IGST;
    }
}
