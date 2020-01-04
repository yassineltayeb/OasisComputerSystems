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
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepository _repo;
        private readonly IMapper _mapper;

        public NationalityController(INationalityRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetNationalities()
        {
            var nationalities = await _repo.GetAll();

            var nationalitiesToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(nationalities);

            return Ok(nationalitiesToReturn);
        }
    }
}