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

        public async Task<Company> CreateCompany(CreateCompanyDTO dto)
        {
            var company = new Company()
            {
                CompanyName = dto.CompanyName,
                INN = dto.INN,
                KPP = dto.KPP,
                OGRN = dto.OGRN,
                ShortName = dto.ShortName,
                JuridicalAddress = dto.JuridicalAddress,
                DirectorName = dto.DirectorName,
                PhoneNumber = dto.PhoneNumber,
                FactAdress = dto.FactAdress
            };
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
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
