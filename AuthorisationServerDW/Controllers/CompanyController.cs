using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Repos.CompanyRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorisationServerDW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepo _companyRepo;

        public CompanyController(ICompanyRepo companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet("companies/company/id")]
        public async Task<IActionResult> GetById(int id)
        {
            var a = await _companyRepo.GetCompanyById(id);
            return Ok(a);
        }
        [HttpGet("companies/company/name")]
        public async Task<IActionResult> GetById(string name)
        {
            var a = await _companyRepo.GetCompanyByName(name);
            return Ok(a);
        }
        [HttpGet("companies/company/inn")]
        public async Task<IActionResult> GetByInn(string inn)
        {
            var a = await _companyRepo.GetCompanyByINN(inn);
            return Ok(a);
        }
        [HttpPost("companies/company/create")]
        public async Task<IActionResult> CreateCompany(CreateCompanyDTO dto)
        {
            var a = await _companyRepo.CreateCompany(dto);
            return Ok(a);
        }
    }
}
