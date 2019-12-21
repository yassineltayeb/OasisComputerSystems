using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class TicketNoteRepository : Repository<TicketNote>, ITicketNoteRepository
    {
        public TicketNoteRepository(DataContext context)
            : base(context)
        {
        }
    }
}