using System.Collections.Generic;
using System.Collections.ObjectModel;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientForDetailsDto
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
        public int? UpdatedById { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<ClientsModulesForDetailsDto> ClientsModules { get; set; }      
        public ICollection<ClientContactForDetailsDto> ClientContacts { get; set; }
        public ICollection<ClientContactSupportForDetailsDto> ClientContactSupports { get; set; }

        public ClientForDetailsDto()
        {
            ClientsModules = new Collection<ClientsModulesForDetailsDto>();
            ClientContacts = new Collection<ClientContactForDetailsDto>();
            ClientContactSupports = new Collection<ClientContactSupportForDetailsDto>();
        }
    }
}