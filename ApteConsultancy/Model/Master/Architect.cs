﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApteConsultancy.Models.Master
{
    public class Architect
    {
        [Key]
        public int? ArchitectId { get; set; } 
        public string? CompanyName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set;}
        public string? AddressLine3 { get; set;}
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostalCode { get; set; }
        public string? ContactPerson1 { get; set; }
        public string? Designation1 { get; set; }
        public int MobileNumber1 { get; set; }
        public string? Email1 { get; set; }
        public string? ContactPerson2 { get; set; }
        public string? Designation2 { get; set; }
        public int MobileNumber2 { get; set; }
        public string? Email2 { get; set; }
        public string? PanNumber { get; set; }
        public string? GstNUmber { get; set; }
        public ICollection<Project>? Projects { get; set; } = new List<Project>();
    }
}
