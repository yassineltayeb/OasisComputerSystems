namespace OasisComputerSystems.API.Dtos.Tickets
{
    public class ClientsActiveTickets
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int NoOfTickets { get; set; }
        public string AccountManager { get; set; }
    }
}