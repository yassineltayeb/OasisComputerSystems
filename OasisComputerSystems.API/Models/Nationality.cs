using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class Nationality
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}