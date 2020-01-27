using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class SystemModuleRepository : Repository<SystemModule>, ISystemModuleRepository
    {
        public SystemModuleRepository(DataContext context)
           : base(context)
        {
        }
    }
}