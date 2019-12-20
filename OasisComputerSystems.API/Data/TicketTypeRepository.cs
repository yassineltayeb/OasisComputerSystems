using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class TicketTypeRepository : Repository<TicketType>, ITicketTypeRepository
    {
        public TicketTypeRepository(DataContext context)
            : base(context)
        {
        }

    }
}