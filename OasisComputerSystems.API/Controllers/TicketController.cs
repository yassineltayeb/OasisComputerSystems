using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ITicketNoteRepository _ticketNoteRepository;
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TicketController> _logger;
        private readonly IWebHostEnvironment _host;

        public TicketController(ITicketRepository repo,
                                ITicketNoteRepository ticketNoteRepository,
                                IAuthRepository authRepository,
                                IMapper mapper,
                                ILogger<TicketController> logger,
                                IWebHostEnvironment host)
        {
            _repo = repo;
            _ticketNoteRepository = ticketNoteRepository;
            _authRepository = authRepository;
            _mapper = mapper;
            _logger = logger;
            _host = host;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTickets([FromQuery] TicketParams ticketParams)
        {
            var tickets = await _repo.GetAll(ticketParams);

            var ticketsToReturn = _mapper.Map<IEnumerable<TicketForListDto>>(tickets);

            Response.AddPagination(tickets.CurrentPage, tickets.PageSize, tickets.TotalCount, tickets.TotalPages);

            return Ok(ticketsToReturn);
        }

        [HttpGet("{id}", Name = "GetTicket")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var ticket = await _repo.Get(id);

            var ticketsToReturn = _mapper.Map<TicketForListDto>(ticket);

            return Ok(ticketsToReturn);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddTicket([FromForm] TicketForRegisterDto ticketForRegisterDto)
        {
            var ticket = _mapper.Map<Ticket>(ticketForRegisterDto);

            ticket.TicketNo = await _repo.GetTicketNo(ticketForRegisterDto.ClientId);
            ticket.SubmittedById = _authRepository.GetCurrentUserId();

            var ticketNote = new TicketNote
            {
                TicketId = ticket.Id,
                Notes = "Ticket Opened " + Environment.NewLine + ticket.ProblemDescription,
                OasisComment = true,
                CreatedById = ticket.SubmittedById
            };

            ticket.TicketNotes.Add(ticketNote);

            _repo.Add(ticket);

            await _repo.SaveAll();

            if (ticketForRegisterDto.Attachments != null)
                Files.UploadFiles(ticket.Id, ticketForRegisterDto.Attachments);

            Emails.SendEmail("Subject", "Body", "y.eltayeb@oasisoft.net", ticketForRegisterDto.Attachments, Emails.Priority.High);

            var ticketToReturn = _mapper.Map<TicketForRegisterDto>(ticket);

            return Ok(ticketToReturn);
        }

        [HttpPut("{id}", Name = "UpdateTicket")]
        public async Task<IActionResult> UpdateTicket(int id, TicketForUpdateDto ticketForUpdateDto)
        {
            var ticket = await _repo.Get(id);

            if (ticket == null)
                return BadRequest("Invalid ticket");

            _mapper.Map(ticketForUpdateDto, ticket);

            await _repo.SaveAll();

            var ticketToReturn = _mapper.Map<TicketForListDto>(ticket);

            return Ok(ticketToReturn);
        }

    }
}