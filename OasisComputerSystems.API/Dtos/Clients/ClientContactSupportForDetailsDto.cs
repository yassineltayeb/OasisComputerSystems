namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientContactSupportForDetailsDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ClientForListDto Client { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}