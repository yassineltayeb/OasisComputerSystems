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
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _repo;
        private readonly IMapper _mapper;

        public CountryController(ICountryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await _repo.GetAll();

            var countriesToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(countries);

            return Ok(countriesToReturn);
        }
    }
}