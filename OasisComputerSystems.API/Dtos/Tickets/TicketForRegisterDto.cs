using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketForRegisterDto
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int TicketNo { get; set; }
        [Required]
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
        public int SubmittedById { get; set; }
        public DateTime SubmittedOn { get; set; }

        public ICollection<TicketNoteForRegisterDto> TicketNotes { get; set; }
        public ICollection<IFormFile> Attachments { get; set; }

        public TicketForRegisterDto()
        {
            Reminders = 0;
            HighPriority = false;
            SubmittedOn = DateTime.Now;
            TicketNotes = new Collection<TicketNoteForRegisterDto>();
        }
    }
}