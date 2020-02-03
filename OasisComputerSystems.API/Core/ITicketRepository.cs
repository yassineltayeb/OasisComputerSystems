using System.Collections.Generic;
using System.Threading.Tasks;
using OasisComputerSystems.API.Dtos.Tickets;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Core
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<int> GenerateTicketNo(int id);
        Task<PagedList<Ticket>> GetAll(TicketParams ticketParams);

        Task<IEnumerable<ClientsActiveTickets>> GetClientsActiveTickets();
    }
}