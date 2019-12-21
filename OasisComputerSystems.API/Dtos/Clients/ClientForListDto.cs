using System;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientForListDto
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Address { get; set; }
        public string VATNo { get; set; }
        public string TelephoneNumber { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public string TechnicalDetails { get; set; }
        public int CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedById { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedById { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}