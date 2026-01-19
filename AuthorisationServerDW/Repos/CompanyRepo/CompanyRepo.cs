using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorisationServerDW.Repos.CompanyRepo
{
    public class CompanyRepo : ICompanyRepo
    {
        private readonly AppDbContext _context;

        public CompanyRepo(AppDbContext context)
        {
            _context = context;
        }

        public Task<Company> CreateCompany(CreateCompanyDTO company)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await _context.Companies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Company> GetCompanyByINN(string inn)
        {
            return await _context.Companies.FirstOrDefaultAsync(x => x.INN == inn);
        }

        public async Task<Company> GetCompanyByName(string name)
        {
            return await _context.Companies.FirstOrDefaultAsync(x => x.CompanyName == name);
        }
    }
}
