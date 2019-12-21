using System;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class TicketNote
    {
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public bool OasisComment { get; set; }
        [Required]
        public int CreatedById { get; set; }
        public StaffProfile CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public TicketNote()
        {
            CreatedOn = DateTime.Now;
        }
    }
}