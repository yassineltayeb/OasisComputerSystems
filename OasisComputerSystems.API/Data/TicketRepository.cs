using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos.Tickets;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly DataContext _context;

        // Constructor
        public TicketRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }

        // Get All Tickets With Pagination
        public async Task<PagedList<Ticket>> GetAll(TicketParams ticketParams)
        {
            // Get Tickets List
            var tickets = _context.Tickets
                .Include(t => t.Client)
                .Include(t => t.Priority)
                .Include(t => t.TicketType)
                .Include(t => t.AssignedTo)
                .Include(t => t.SystemModule)
                .Include(t => t.SubmittedBy)
                .Include(t => t.ClosedBy)
                .Include(t => t.ApprovedBy)
                .OrderBy(t => t.TicketNo)
                .AsQueryable();

            // Filter By
            if (ticketParams.Status != null)
                tickets = tickets.Where(t => t.Status == ticketParams.Status);

            if (ticketParams.ClientName != null)
                tickets = tickets.Where(t => t.Client.NameEn.Contains(ticketParams.ClientName));

            if (ticketParams.PriorityId.HasValue)
                tickets = tickets.Where(t => t.PriorityId == ticketParams.PriorityId);

            if (ticketParams.TicketTypeId.HasValue)
                tickets = tickets.Where(t => t.TicketTypeId == ticketParams.TicketTypeId);

            if (ticketParams.AssignedToId.HasValue)
                tickets = tickets.Where(t => t.AssignedToId == ticketParams.AssignedToId);

            if (ticketParams.SystemModuleId.HasValue)
                tickets = tickets.Where(t => t.SystemModuleId == ticketParams.SystemModuleId);

            if (ticketParams.Subject != null)
                tickets = tickets.Where(t => t.Subject.Contains(ticketParams.Subject));

            // Order By
            var columnsMap = OrderByColumnsMap();

            if (ticketParams.OrderBy != null)
            {
                if (ticketParams.IsOrderAscending)
                    tickets = tickets.OrderBy(columnsMap[ticketParams.OrderBy]);
                else
                    tickets = tickets.OrderByDescending(columnsMap[ticketParams.OrderBy]);
            }

            // Pagination
            return await PagedList<Ticket>.CreateAsync(tickets, ticketParams.PageNumber, ticketParams.ItemsPerPage);
        }

        // Get Clients Active Tickets
        public async Task<IEnumerable<ClientsActiveTickets>> GetClientsActiveTickets()
        {
            return await _context.Tickets
                        .GroupBy(t => new ClientsActiveTickets
                        {
                            ClientId = t.Client.Id,
                            ClientName = t.Client.NameEn,
                            AccountManager = t.Client.AccountManager.FullNameEn
                        })
                        .Select(group => new ClientsActiveTickets
                        {
                            ClientId = group.Key.ClientId,
                            ClientName = group.Key.ClientName,
                            NoOfTickets = group.Count(),
                            AccountManager = group.Key.AccountManager
                        })
                        .OrderByDescending(group => group.NoOfTickets)
                        .ToListAsync();
        }

        // Get Ticket By ID
        public new async Task<Ticket> Get(int id)
        {
            return await _context.Tickets
                .Include(t => t.Client)
                .Include(t => t.Priority)
                .Include(t => t.TicketType)
                .Include(t => t.AssignedTo)
                .Include(t => t.SystemModule)
                .Include(t => t.SubmittedBy)
                .Include(t => t.ClosedBy)
                .Include(t => t.ApprovedBy)
                .SingleOrDefaultAsync(t => t.Id == id);
        }

        // Generate Ticket No.
        public async Task<int> GenerateTicketNo(int clientId)
        {
            var maxTicketNo = await _context.Tickets
                                .Where(t => t.ClientId == clientId)
                                .OrderByDescending(x => x.TicketNo)
                                .Select(t => t.TicketNo)
                                .FirstOrDefaultAsync();

            if (maxTicketNo == 0)
                maxTicketNo = 1001;
            else
                maxTicketNo += 1;

            return maxTicketNo;
        }

        // Order Parameters
        private Dictionary<string, Expression<Func<Ticket, object>>> OrderByColumnsMap()
        {
            return new Dictionary<string, Expression<Func<Ticket, object>>>()
            {
                ["clientName"] = t => t.Client.NameEn,
                ["ticketNo"] = t => t.TicketNo,
                ["status"] = t => t.Status,
                ["priority"] = t => t.Priority.Name,
                ["ticketType"] = t => t.TicketType.Name,
                ["assignedTo"] = t => t.AssignedTo.FullNameEn,
                ["systemModule"] = t => t.SystemModule.Name,
                ["subject"] = t => t.Subject,
                ["problemDescription"] = t => t.ProblemDescription,
                ["reminders"] = t => t.Reminders,
                ["submittedBy"] = t => t.SubmittedBy.FullNameEn,
                ["submittedOn"] = t => t.SubmittedOn,
                ["closedBy"] = t => t.ClosedBy.FullNameEn,
                ["closedOn"] = t => t.ClosedOn,
                ["approvedBy"] = t => t.ApprovedBy.FullNameEn,
                ["approvedOn"] = t => t.ApprovedOn
            };
        }
    }
}