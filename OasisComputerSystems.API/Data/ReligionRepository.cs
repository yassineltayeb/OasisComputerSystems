using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class ReligionRepository : Repository<Religion>, IReligionRepository
    {
        public ReligionRepository(DataContext context)
            : base(context)
        {
        }
    }
}