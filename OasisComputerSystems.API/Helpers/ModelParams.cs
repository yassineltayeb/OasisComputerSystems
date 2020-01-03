namespace OasisComputerSystems.API.Helpers
{
    public class ModelParams
    {
        private const int MaxPageSize = 100;
        public int PageNumber { get; set; } = 1;
        private int itemsPerPage = 10;
        public int ItemsPerPage
        {
            get { return itemsPerPage; }
            set { itemsPerPage = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public string OrderBy { get; set; }
        public bool IsOrderAscending { get; set; }
    }
}