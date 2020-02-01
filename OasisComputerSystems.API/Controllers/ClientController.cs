using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OasisComputerSystems.API.Core;
using OasisComputerSystems.API.Dtos;
using OasisComputerSystems.API.Dtos.Clients;
using OasisComputerSystems.API.Helpers;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _repo;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;

        public ClientController(IClientRepository repo, IMapper mapper, IAuthRepository authRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _authRepository = authRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients([FromQuery] ClientParams clientParams)
        {
            var clients = await _repo.GetAll(clientParams);

            var clientsToReturn = _mapper.Map<IEnumerable<ClientForListDto>>(clients);

            Response.AddPagination(clients.CurrentPage, clients.PageSize, clients.TotalCount, clients.TotalPages);

            return Ok(clientsToReturn);
        }

        [HttpGet]
        [Route("GetAllClients")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _repo.GetAll();

            var clientsToReturn = _mapper.Map<IEnumerable<KeyValuePairs>>(clients);

            return Ok(clientsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await _repo.Get(id);

            var clientsToReturn = _mapper.Map<ClientForDetailsDto>(client);

            return Ok(clientsToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(ClientForRegisterDto clientForRegisterDto)
        {
            var client = _mapper.Map<Client>(clientForRegisterDto);
            client.CreatedById = _authRepository.GetCurrentUserId();

            _repo.Add(client);

            await _repo.SaveAll();

            var clientToReturn = _mapper.Map<ClientForRegisterDto>(client);

            return Ok(clientToReturn);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, ClientForUpdateDto clientForUpdateDto)
        {
            var client = await _repo.Get(id);

            if (client == null)
                return BadRequest("Invalid client");

            _mapper.Map(clientForUpdateDto, client);

            client.UpdatedById = _authRepository.GetCurrentUserId();
            client.UpdatedOn = DateTime.Now;

            await _repo.SaveAll();

            var clientToReturn = _mapper.Map<ClientForDetailsDto>(client);

            return Ok(clientToReturn);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _repo.Get(id);

            if (client == null)
                return BadRequest("Invalid client");

            client.IsDeleted = true;
            client.DeletedById = _authRepository.GetCurrentUserId();
            client.DeletedOn = DateTime.Now;

            await _repo.SaveAll();

            return Ok();
        }

    }
}