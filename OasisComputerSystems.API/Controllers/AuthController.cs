using System;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using OasisComputerSystems.API.Dtos.StaffProfiles;
using OasisComputerSystems.API.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace OasisComputerSystems.API.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly UserManager<StaffProfile> _userManager;
        private readonly SignInManager<StaffProfile> _signInManager;

        public AuthController(IConfiguration config, IMapper mapper,
                              UserManager<StaffProfile> userManager,
                              SignInManager<StaffProfile> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(StaffProfileForRegisterDto staffProfileForRegisterDto)
        {
            var staffProfile = _mapper.Map<StaffProfile>(staffProfileForRegisterDto);

            var result = await _userManager.CreateAsync(staffProfile, staffProfileForRegisterDto.Password);

            var userToReturn = _mapper.Map<StaffProfileForRegisterDto>(staffProfile);

            if (result.Succeeded)
            {
                var createdUser = await _userManager.FindByNameAsync(staffProfileForRegisterDto.UserName);

                if (staffProfileForRegisterDto.UserName.ToLower() == "oasis")
                {
                    await _userManager.AddToRoleAsync(createdUser, "Admin");
                }
                else if (staffProfileForRegisterDto.UserName.ToLower().Contains("oasis"))
                {
                    await _userManager.AddToRoleAsync(createdUser, "Member");
                }
                else
                {
                    await _userManager.AddToRoleAsync(createdUser, "Client");
                }

                return Ok(userToReturn);
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(StaffProfileForLoginDto staffProfileForLoginDto)
        {
            var staffProfile = await _userManager.FindByNameAsync(staffProfileForLoginDto.UserName);

            var result = await _signInManager.CheckPasswordSignInAsync(staffProfile, staffProfileForLoginDto.Password, false);

            if (result.Succeeded)
            {
                staffProfile = await _userManager.Users
                                        .Include(u => u.MaritalStatus)
                                        .Include(u => u.Nationality)
                                        .Include(u => u.Religion)
                                        .Include(u => u.Gender)
                                        .SingleOrDefaultAsync(u => u.Id == staffProfile.Id);

                var staffProfileToReturn = _mapper.Map<StaffProfile, StaffProfileForListDto>(staffProfile);

                return Ok(new
                {
                    token = await GenerateJwtToken(staffProfile),
                    user = staffProfileToReturn
                });
            }

            return Unauthorized();
        }

        private async Task<string> GenerateJwtToken(StaffProfile staffProfile)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, staffProfile.Id.ToString()),
                new Claim(ClaimTypes.Name, staffProfile.UserName)

            };

            var roles = await _userManager.GetRolesAsync(staffProfile);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}