using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos.Tickets;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketNoteController : ControllerBase
    {
        private readonly ITicketNoteRepository _repo;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;

        public TicketNoteController(ITicketNoteRepository repo, IMapper mapper, IAuthRepository authRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _authRepository = authRepository;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTicketNotes()
        {
            var ticketNotes = await _repo.GetAll();

            var ticketNotesToReturn = _mapper.Map<IEnumerable<TicketNoteForListDto>>(ticketNotes);

            return Ok(ticketNotesToReturn);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddTicketNote(TicketNoteForRegisterDto ticketNoteForRegisterDto)
        {
            var ticketNote = _mapper.Map<TicketNote>(ticketNoteForRegisterDto);

            ticketNote.CreatedById = _authRepository.GetCurrentUserId();

            _repo.Add(ticketNote);

            await _repo.SaveAll();

            var ticketNoteToReturn = _mapper.Map<TicketNoteForListDto>(ticketNote);

            return Ok(ticketNoteToReturn);
        }
    }
}