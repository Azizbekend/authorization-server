using AuthorisationServerDW.DTOs;
using AuthorisationServerDW.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthorisationServerDW.Repos.UserRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AttachUsersCompany(UserCompanyAttach dto)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == dto.UserId);
            var link = new UserCompany()
            {
                UserId = dto.UserId,
                CompanyId = dto.CompanyId
            };
            _context.UsersCompany.Add(link);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Authorise(UserAuthorisationBetaDTO dto)
        {
            var check = await _context.Users.FirstOrDefaultAsync(x => x.Login == dto.Login && x.Password == dto.Password);
            if (check != null)
            {
                return check;
            }
            else
                throw new Exception("Login or password is incorrect!");
        }

        public async Task<User> CreateUser(UserCreateDTO dto)
        {
            var user = new User()
            {
                Login = dto.Login,
                Password = dto.Password,
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                BaseRoleId = dto.BaseRoleId,
                Patronymic = dto.Patronymic,
                PhoneNumber = dto.PhoneNumber,
                Adress = dto.Adress
            };
            _context.Users.Add(user);   
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<ICollection<User>> GetUserByCompany(int id)
        {
            var userLink = await _context.UsersCompany.Where(x => x.UserId == id).ToListAsync();
            var users = new List<User>();
            foreach (var user in userLink)
            {
                var u = await _context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);
                users.Add(u);
            }
            return users;
        }

        public async Task<User> GetUserById(int id)
        {
            var a = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (a == null)
            {
                throw new Exception("Not found");
            }
            else
                return a;
        }

        public async Task<User> GetUserByName(string username)
        {
            var a = await _context.Users.FirstOrDefaultAsync(x => x.Login == username);
            if (a == null)
            {
                throw new Exception("Not found");
            }
            else
                return a;
        }
    }
}
