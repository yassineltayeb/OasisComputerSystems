using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly DataContext _context;
        public TicketRepository(DataContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<PagedList<Ticket>> GetAll(TicketParams ticketParams)
        {
            //Get Clients List
            var tickets = _context.Tickets
                .Include(c => c.Priority)
                .Include(c => c.TicketType)
                .Include(c => c.AssignedTo)
                .Include(c => c.SystemModule)
                .Include(c => c.SubmittedBy)
                .Include(c => c.ClosedBy)
                .Include(c => c.ApprovedBy)
                .OrderBy(c => c.TicketNo)
                .AsQueryable();

            //Filter By
            if (ticketParams.ClientId.HasValue)
                tickets = tickets.Where(c => c.ClientId == ticketParams.ClientId);

            if (ticketParams.PriorityId.HasValue)
                tickets = tickets.Where(c => c.PriorityId == ticketParams.PriorityId);

            if (ticketParams.TicketTypeId.HasValue)
                tickets = tickets.Where(c => c.TicketTypeId == ticketParams.TicketTypeId);

            if (ticketParams.AssignedToId.HasValue)
                tickets = tickets.Where(c => c.AssignedToId == ticketParams.AssignedToId);

            if (ticketParams.SystemModuleId.HasValue)
                tickets = tickets.Where(c => c.SystemModuleId == ticketParams.SystemModuleId);

            if (ticketParams.Subject != null)
                tickets = tickets.Where(c => c.Subject.Contains(ticketParams.Subject));

            if (ticketParams.ProblemDescription != null)
                tickets = tickets.Where(c => c.ProblemDescription.Contains(ticketParams.ProblemDescription));

            //Order By
            var columnsMap = OrderByColumnsMap();

            if (ticketParams.OrderBy != null)
            {
                if (ticketParams.IsOrderAscending)
                    tickets = tickets.OrderBy(columnsMap[ticketParams.OrderBy]);
                else
                    tickets = tickets.OrderByDescending(columnsMap[ticketParams.OrderBy]);
            }

            //Pagination
            return await PagedList<Ticket>.CreateAsync(tickets, ticketParams.PageNumber, ticketParams.ItemsPerPage);
        }

        public new async Task<Ticket> Get(int id)
        {
            return await _context.Tickets
                .Include(c => c.Priority)
                .Include(c => c.TicketType)
                .Include(c => c.AssignedTo)
                .Include(c => c.SystemModule)
                .Include(c => c.SubmittedBy)
                .Include(c => c.ClosedBy)
                .Include(c => c.ApprovedBy)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<int> GetTicketNo(int clientId)
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

        private Dictionary<string, Expression<Func<Ticket, object>>> OrderByColumnsMap()
        {
            return new Dictionary<string, Expression<Func<Ticket, object>>>()
            {
                ["priority"] = c => c.Priority.Name,
                ["ticketType"] = c => c.TicketType.Name,
                ["assignedTo"] = c => c.AssignedTo.FullNameEn,
                ["systemModule"] = c => c.SystemModule.Name,
                ["subject"] = c => c.Subject,
                ["problemDescription"] = c => c.ProblemDescription,
                ["submittedBy"] = c => c.SubmittedBy.FullNameEn,
                ["submittedOn"] = c => c.SubmittedOn,
                ["closedBy"] = c => c.ClosedBy.FullNameEn,
                ["approvedBy"] = c => c.ApprovedBy.FullNameEn,
                ["approvedOn"] = c => c.ApprovedOn
            };
        }
    }
}