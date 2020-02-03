using System.Collections.Generic;
using System.Threading.Tasks;
using OasisComputerSystems.API.Dtos.Tickets;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Core
{
    public interface ITicketTypeRepository : IRepository<TicketType>
    {
    }
}