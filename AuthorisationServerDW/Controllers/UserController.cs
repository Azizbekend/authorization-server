using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;
using AuthorisationServerDW.Repos.UserRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorisationServerDW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("users/user/id")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = _userRepo.GetUserById(id);
            return Ok(user);
        }

        [HttpGet("users/user/name")]
        public async Task<IActionResult> GetByName(string name)
        {
            var user = _userRepo.GetUserByName(name);
            return Ok(user);
        }
        [HttpPost("users/user/create")]
        public async Task<IActionResult> Create(UserCreateDTO user)
        {
            var userqq = await _userRepo.CreateUser(user);
            return Ok(userqq);
        }
        [HttpPost("users/user/authorise")]
        public async Task<IActionResult> Authorise(UserAuthorisationBetaDTO authorisationBetaDTO)
        {
            try
            {
                var a = _userRepo.Authorise(authorisationBetaDTO);
                return Ok(a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("usets/user/attachCompany")]
        public async Task<IActionResult> AttachCompany(UserCompanyAttach dto)
        {
            await _userRepo.AttachUsersCompany(dto);
            return Ok(dto);
        }
    }
}
