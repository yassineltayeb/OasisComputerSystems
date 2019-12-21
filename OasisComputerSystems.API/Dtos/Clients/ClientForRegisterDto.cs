using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientForRegisterDto
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
        public DateTime CreatedOn { get; set; }
        public ICollection<ClientsModulesForRegisterDto> ClientsModules { get; set; }
        public ICollection<ClientContactForRegisterDto> ClientContacts { get; set; }
        public ICollection<ClientContactSupportForRegisterDto> ClientContactSupports { get; set; }

        public ClientForRegisterDto()
        {
            CreatedOn = DateTime.Now;
            ClientsModules = new Collection<ClientsModulesForRegisterDto>();
            ClientContacts = new Collection<ClientContactForRegisterDto>();
            ClientContactSupports = new Collection<ClientContactSupportForRegisterDto>();
        }
    }
}