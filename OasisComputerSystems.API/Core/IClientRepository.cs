using System.Collections.Generic;
using System.Threading.Tasks;
using OasisComputerSystems.API.Data;
using OasisComputerSystems.API.Dtos;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Core
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<PagedList<Client>> GetAll(ClientParams clientParams);
    }
}