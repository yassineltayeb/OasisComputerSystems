namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientContactForRegisterDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}