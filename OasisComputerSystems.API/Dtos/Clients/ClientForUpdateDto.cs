using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientForUpdateDto
    {
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
        public string TechnicalDetails { get; set; }
        public int? AccountManagerId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<ClientsModulesForRegisterDto> ClientModules { get; set; }
        public ICollection<ClientContactForRegisterDto> ClientContacts { get; set; }
        public ICollection<ClientContactSupportForRegisterDto> ClientContactSupports { get; set; }

        public ClientForUpdateDto()
        {
            UpdatedOn = DateTime.Now;
            ClientModules = new Collection<ClientsModulesForRegisterDto>();
            ClientContacts = new Collection<ClientContactForRegisterDto>();
            ClientContactSupports = new Collection<ClientContactSupportForRegisterDto>();
        }
    }
}