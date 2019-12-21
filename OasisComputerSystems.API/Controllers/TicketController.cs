using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos.Tickets;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository _repo;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;

        public TicketController(ITicketRepository repo, IMapper mapper, IAuthRepository authRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _authRepository = authRepository;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTickets([FromQuery] TicketParams ticketParams)
        {
            var tickets = await _repo.GetAll(ticketParams);

            var ticketsToReturn = _mapper.Map<IEnumerable<TicketForListDto>>(tickets);

            Response.AddPagination(tickets.CurrentPage, tickets.PageSize, tickets.TotalCount, tickets.TotalPages);

            return Ok(ticketsToReturn);
        }

        [HttpGet("{id}", Name="GetTicket")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var ticket = await _repo.Get(id);

            var ticketsToReturn = _mapper.Map<TicketForListDto>(ticket);

            return Ok(ticketsToReturn);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddTicket(TicketForRegisterDto ticketForRegisterDto)
        {
            var ticket = _mapper.Map<Ticket>(ticketForRegisterDto);
            
            ticket.TicketNo = await _repo.GetTicketNo(ticketForRegisterDto.ClientId);
            ticket.SubmittedById = _authRepository.GetCurrentUserId();

            _repo.Add(ticket);

            await _repo.SaveAll();

            var ticketToReturn = _mapper.Map<TicketForRegisterDto>(ticket);

            return Ok(ticketToReturn);
        }

        [HttpPut("{id}", Name="UpdateTicket")]
        public async Task<IActionResult> UpdateTicket(int id, TicketForUpdateDto ticketForUpdateDto)
        {
            var ticket = await _repo.Get(id);

            if (ticket == null)
                return BadRequest("Invalid ticket");

            _mapper.Map(ticketForUpdateDto, ticket);
            
            // ticket.UpdatedById = _authRepository.GetCurrentUserId();

            await _repo.SaveAll();

            var ticketToReturn = _mapper.Map<TicketForListDto>(ticket);

            return Ok(ticketToReturn);
        }
    }
}