using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using OasisComputerSystems.API.Dtos.Clients;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketForListDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientForListDto Client { get; set; }
        public int TicketNo { get; set; }
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public int TicketTypeId { get; set; }
        public string TicketType { get; set; }
        public int? AssignedToId { get; set; }
        public string AssignedTo { get; set; }
        public int SystemModuleId { get; set; }
        public string SystemModule { get; set; }
        public string Subject { get; set; }
        public string ProblemDescription { get; set; }
        public int SubmittedById { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime SubmittedOn { get; set; }
        public int? ClosedById { get; set; }
        public string ClosedBy { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? ApprovedById { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public ICollection<TicketNoteForRegisterDto> TicketNotes { get; set; }

        public TicketForListDto()
        {
            TicketNotes = new Collection<TicketNoteForRegisterDto>();
        }
    }
}