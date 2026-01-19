using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;
using System.Runtime.InteropServices;

namespace AuthorisationServerDW.Repos.CompanyRepo
{
    public interface ICompanyRepo
    {
        public Task<Company> CreateCompany(CreateCompanyDTO company);
        public Task<Company> GetCompanyById(int id);
        public Task<Company> GetCompanyByName(string name);
        public Task<Company> GetCompanyByINN(string inn);
    }
}
