namespace OasisComputerSystems.API.Models
{
    public class ClientsModules
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int SystemModuleId { get; set; }
        public SystemModule SystemModule { get; set; }
    }
}