
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;
using UserManagement.UserDbContext;

namespace UserManagement.Repository
{
    public class UserServices : IUserServices
    {
        private readonly UsersDbContext _dbContext;

        public UserServices(UsersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _dbContext.users.ToListAsync();
        }
        public async Task<Users> GetUsersById(int id)
        {
            return await _dbContext.users.FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<bool> AddUser(Users user)
        {
               await _dbContext.users.AddAsync(user);
               await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
