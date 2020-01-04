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
    public class MaritalStatusController : ControllerBase
    {
        private readonly IMaritalStatusRepository _repo;
        private readonly IMapper _mapper;

        public MaritalStatusController(IMaritalStatusRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetMaritalStatuses()
        {
            var maritalStatuses = await _repo.GetAll();

            var maritalStatusesToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(maritalStatuses);

            return Ok(maritalStatusesToReturn);
        }
    }
}