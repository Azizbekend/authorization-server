using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;

namespace AuthorisationServerDW.Repos.UserRepo
{
    public interface IUserRepo
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByName(string username);
        Task<User> CreateUser(UserCreateDTO dto);
        Task<UserAuthorisationResponseDTO> Authorise(UserAuthorisationBetaDTO dto);
        Task AttachUsersCompany(UserCompanyAttach dto);
        Task<ICollection<User>> GetUserByCompany(int id);
        
    }
}
