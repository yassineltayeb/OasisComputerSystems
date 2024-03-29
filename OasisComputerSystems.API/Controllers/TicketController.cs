using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
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

        [HttpGet]
        public async Task<IActionResult> GetTickets([FromQuery] TicketParams ticketParams)
        {
            var tickets = await _repo.GetAll(ticketParams);

            var ticketsToReturn = _mapper.Map<IEnumerable<TicketForListDto>>(tickets);

            Response.AddPagination(tickets.CurrentPage, tickets.PageSize, tickets.TotalCount, tickets.TotalPages);

            return Ok(ticketsToReturn);
        }

        [HttpGet]
        [Route("GetClientsActiveTickets")]
        public async Task<IActionResult> GetClientsActiveTickets()
        {
            var clientsActiveTickets = await _repo.GetClientsActiveTickets();

            return Ok(clientsActiveTickets);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var ticket = await _repo.Get(id);

            var ticketsToReturn = _mapper.Map<TicketForListDto>(ticket);

            return Ok(ticketsToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> AddTicket([FromForm] TicketForRegisterDto ticketForRegisterDto)
        {
            var ticket = _mapper.Map<Ticket>(ticketForRegisterDto);

            ticket.TicketNo = await _repo.GenerateTicketNo(ticketForRegisterDto.ClientId);
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

            _repo.BeginTransaction();

            await _repo.SaveAll();

            if (ticketForRegisterDto.Attachments != null)
                Files.UploadFiles(ticket.Id, ticketForRegisterDto.Attachments);

            Emails.SendEmail(ticket.Subject, ticket.ProblemDescription, "y.eltayeb@oasisoft.net", ticketForRegisterDto.Attachments, Emails.Priority.High);

            _repo.Commit();

            var ticketToReturn = _mapper.Map<TicketForRegisterDto>(ticket);

            return Ok(ticketToReturn);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddTicketNote(int id, TicketNoteForRegisterDto ticketNoteForRegisterDto)
        {
            var ticket = await _repo.Get(id);

            if (ticket == null)
                return BadRequest("Invalid ticket");

            var ticketNote = new TicketNote
            {
                TicketId = ticket.Id,
                Notes = ticketNoteForRegisterDto.Notes,
                OasisComment = ticketNoteForRegisterDto.OasisComment,
                CreatedById = _authRepository.GetCurrentUserId()
            };

            ticket.TicketNotes.Add(ticketNote);

            await _repo.SaveAll();

            Emails.SendEmail(ticket.Subject, ticketNoteForRegisterDto.Notes, "y.eltayeb@oasisoft.net", null, Emails.Priority.High);

            var ticketToReturn = _mapper.Map<TicketForRegisterDto>(ticket);

            return Ok(ticketToReturn);
        }

        [HttpPut("{id}")]
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