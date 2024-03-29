
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
    public class PriorityController : ControllerBase
    {
        private readonly IPriorityRepository _repo;
        private readonly IMapper _mapper;

        public PriorityController(IPriorityRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPriorities()
        {
            var priorities = await _repo.GetAll();

            var gendersToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(priorities);

            return Ok(gendersToReturn);
        }
    }
}