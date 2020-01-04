
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos;

namespace OasisComputerSystems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypeController : ControllerBase
    {
        private readonly ITicketTypeRepository _repo;
        private readonly IMapper _mapper;

        public TicketTypeController(ITicketTypeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTicketTypes()
        {
            var ticketTypes = await _repo.GetAll();

            var gendersToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(ticketTypes);

            return Ok(gendersToReturn);
        }
    }
}