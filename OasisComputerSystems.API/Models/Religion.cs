using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class Religion
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}