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
    public class SystemModuleController : ControllerBase
    {
        private readonly ISystemModuleRepository _repo;
        private readonly IMapper _mapper;

        public SystemModuleController(ISystemModuleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSystemsModules()
        {
            var systemsModules = await _repo.GetAll();

            var systemsModulesToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(systemsModules);

            return Ok(systemsModulesToReturn);
        }
    }
}