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
    public class ReligionController : ControllerBase
    {
        private readonly IReligionRepository _repo;
        private readonly IMapper _mapper;

        public ReligionController(IReligionRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetReligions()
        {
            var religions = await _repo.GetAll();

            var religionsToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(religions);

            return Ok(religionsToReturn);
        }
    }
}