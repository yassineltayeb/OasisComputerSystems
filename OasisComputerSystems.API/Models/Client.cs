using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string NameEn { get; set; }
        [Required]
        [StringLength(255)]
        public string NameAr { get; set; }
        public string Address { get; set; }
        public string VATNo { get; set; }
        public string TelephoneNumber { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string TechnicalDetails { get; set; }
        public int? AccountManagerId { get; set; }
        public StaffProfile AccountManager { get; set; }
        public int CreatedById { get; set; }
        public StaffProfile CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedById { get; set; }
        public StaffProfile UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public StaffProfile DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<ClientModules> ClientModules { get; set; }      
        public ICollection<ClientContact> ClientContacts { get; set; }
        public ICollection<ClientContactSupport> ClientContactSupports { get; set; }

        public Client()
        {
            CreatedOn = DateTime.Now;
            ClientModules = new Collection<ClientModules>();
            ClientContacts = new Collection<ClientContact>();
            ClientContactSupports = new Collection<ClientContactSupport>();
        }
    }
}