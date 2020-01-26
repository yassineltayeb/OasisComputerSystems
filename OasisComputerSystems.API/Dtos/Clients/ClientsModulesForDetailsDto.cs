namespace OasisComputerSystems.API.Dtos.Clients
{
    public class ClientsModulesForDetailsDto
    {
        public int ClientId { get; set; }
        public ClientForDetailsDto Client { get; set; }
        public int SystemModuleId { get; set; }
        public KeyValuePairs SystemModule { get; set; }
    }
}