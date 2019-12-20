namespace OasisComputerSystems.API.Helpers
{
    public class ClientParams : ModelParams
    {
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public int? CreatedById { get; set; }
    }
}