using System;

namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class TicketNoteForListDto
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Notes { get; set; }
        public bool OasisComment { get; set; }
        public int CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}