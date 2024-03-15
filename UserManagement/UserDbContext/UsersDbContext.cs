using Microsoft.EntityFrameworkCore;
using UserManagement.Models;


namespace UserManagement.UserDbContext
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {

        }

        public DbSet<Users> users {  get; set; }
    }
}
