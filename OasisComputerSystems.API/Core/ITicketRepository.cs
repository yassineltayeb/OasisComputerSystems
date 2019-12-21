using System.Threading.Tasks;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Core
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<int> GetTicketNo(int id);
        Task<PagedList<Ticket>> GetAll(TicketParams ticketParams);
    }
}