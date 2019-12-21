namespace OasisComputerSystems.API.Helpers
{
    public class TicketParams : ModelParams
    {
        public int? ClientId { get; set; }
        public int? PriorityId { get; set; }
        public int? TicketTypeId { get; set; }
        public int? AssignedToId { get; set; }
        public int? SystemModuleId { get; set; }
        public string Subject { get; set; }
        public string ProblemDescription { get; set; }
    }
}