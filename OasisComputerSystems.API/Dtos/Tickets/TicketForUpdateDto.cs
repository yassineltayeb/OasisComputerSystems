using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketForUpdateDto
    {
        public int Id { get; set; }
        public int PriorityId { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
        public int? AssignedToId { get; set; }
        [Required]
        public int SystemModuleId { get; set; }
        [Required]
        [StringLength(255)]
        public string Subject { get; set; }
        [Required]
        public string ProblemDescription { get; set; }
        public int Reminders { get; set; }
        public bool HighPriority { get; set; }
        public int? ClosedById { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? ApprovedById { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public ICollection<TicketNoteForUpdateDto> TicketNotes { get; set; }

        public TicketForUpdateDto()
        {
            TicketNotes = new Collection<TicketNoteForUpdateDto>();
        }
    }
}