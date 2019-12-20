using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class SystemModule
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public ICollection<ClientsModules> ClientsModules { get; set; }
    }
}