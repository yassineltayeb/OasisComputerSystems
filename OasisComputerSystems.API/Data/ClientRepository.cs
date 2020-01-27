using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly DataContext _context;

        // Constructor
        public ClientRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }

        // Get All Clients With Pagination
        public async Task<PagedList<Client>> GetAll(ClientParams clientParams)
        {
            // Get Clients List
            var clients = _context.Clients
                                .Where(c => c.IsDeleted == false)
                                .Include(c => c.Country)
                                .Include(c => c.CreatedBy)
                                .Include(c => c.UpdatedBy)
                                .Include(c => c.ClientsModules)
                                    .ThenInclude(c => c.SystemModule)
                                .Include(c => c.ClientContacts)
                                .Include(c => c.ClientContactSupports)
                                .OrderBy(c => c.NameEn)
                                .AsQueryable();

            // Filter By
            if (clientParams.Name != null)
                clients = clients.Where(c => c.NameEn.Contains(clientParams.Name) || c.NameAr.Contains(clientParams.Name));

            if (clientParams.CountryId.HasValue)
                clients = clients.Where(c => c.CountryId == clientParams.CountryId);

            if (clientParams.CreatedById.HasValue)
                clients = clients.Where(c => c.CreatedById == clientParams.CreatedById);

            // Order By
            var columnsMap = OrderByColumnsMap();

            if (clientParams.OrderBy != null)
            {
                if (clientParams.IsOrderAscending)
                    clients = clients.OrderBy(columnsMap[clientParams.OrderBy]);
                else
                    clients = clients.OrderByDescending(columnsMap[clientParams.OrderBy]);
            }

            // Pagination
            return await PagedList<Client>.CreateAsync(clients, clientParams.PageNumber, clientParams.ItemsPerPage);
        }

        // Get All Clients List
        public new async Task<IEnumerable<KeyValuePairs>> GetAll()
        {
            var clients = await _context.Clients
                                        .Select(c => new KeyValuePairs { Id = c.Id, Name = c.NameEn })
                                        .ToListAsync();

            return clients;
        }

        // Get Client By ID
        public new async Task<Client> Get(int id)
        {
            return await _context.Clients
                                .Where(c => c.IsDeleted == false)
                                .Include(c => c.Country)
                                .Include(c => c.CreatedBy)
                                .Include(c => c.UpdatedBy)
                                .Include(c => c.ClientsModules)
                                    .ThenInclude(c => c.SystemModule)
                                .Include(c => c.ClientContacts)
                                .Include(c => c.ClientContactSupports)
                                .SingleOrDefaultAsync(c => c.Id == id);
        }

        // Order Parameters
        private Dictionary<string, Expression<Func<Client, object>>> OrderByColumnsMap()
        {
            return new Dictionary<string, Expression<Func<Client, object>>>()
            {
                ["id"] = c => c.Id,
                ["nameEn"] = c => c.NameEn,
                ["nameAr"] = c => c.NameAr,
                ["address"] = c => c.Address,
                ["vATNo"] = c => c.VATNo,
                ["telephoneNumber"] = c => c.TelephoneNumber,
                ["country"] = c => c.Country.Name,
                ["technicalDetails"] = c => c.TechnicalDetails,
                ["createdBy"] = c => c.CreatedBy.FullNameEn,
                ["createdOn"] = c => c.CreatedOn,
                ["updatedBy"] = c => c.UpdatedBy.FullNameEn,
                ["updatedOn"] = c => c.UpdatedOn
            };
        }
    }
}