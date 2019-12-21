using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace OasisComputerSystems.API.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public int TicketNo { get; set; }
        [Required]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }
        public int? AssignedToId { get; set; }
        public StaffProfile AssignedTo { get; set; }
        [Required]
        public int SystemModuleId { get; set; }
        public SystemModule SystemModule { get; set; }
        [Required]
        [StringLength(255)]
        public string Subject { get; set; }
        [Required]
        public string ProblemDescription { get; set; }
        public int SubmittedById { get; set; }
        public StaffProfile SubmittedBy { get; set; }
        public DateTime SubmittedOn { get; set; }

        public int? ClosedById { get; set; }
        public StaffProfile ClosedBy { get; set; }
        public DateTime? ClosedOn { get; set; }

        public int? ApprovedById { get; set; }
        public StaffProfile ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }

        public ICollection<TicketNote> TicketNotes { get; set; }

        public Ticket()
        {
            TicketNotes = new Collection<TicketNote>();
        }

    }
}