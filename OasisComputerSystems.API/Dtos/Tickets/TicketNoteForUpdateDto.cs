using System;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketNoteForUpdateDto
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
        public int? ClosedById { get; set; }
        public DateTime ClosedOn { get; set; }

        public int? ApprovedById { get; set; }
        public DateTime ApprovedOn { get; set; }
    }
}