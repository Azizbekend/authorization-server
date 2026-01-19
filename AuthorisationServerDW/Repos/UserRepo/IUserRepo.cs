using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;

namespace AuthorisationServerDW.Repos.UserRepo
{
    public interface IUserRepo
    {
        Task<CreateUserDTO> GetUserById(int id);
        Task<CreateUserDTO> GetUserByName(string username);
        Task<CreateUserDTO> CreateUser(UserCreateDTO dto);
        Task<CreateUserDTO> Authorise(UserAuthorisationBetaDTO dto);
        Task AttachUsersCompany(UserCompanyAttach dto);
    }
}
