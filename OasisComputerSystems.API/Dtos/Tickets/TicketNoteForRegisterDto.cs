using System;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketNoteForRegisterDto
    {
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public bool OasisComment { get; set; }
        [Required]
        public int CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }

        public TicketNoteForRegisterDto()
        {
            CreatedOn = DateTime.Now;
        }
    }
}