using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(DataContext context)
            : base(context)
        {
        }
    }
}