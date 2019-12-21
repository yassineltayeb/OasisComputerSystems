using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class PriorityRepository : Repository<Priority>, IPriorityRepository
    {
        public PriorityRepository(DataContext context)
            : base(context)
        {
        }
    }
}