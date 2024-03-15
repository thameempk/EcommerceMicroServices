using UserManagement.Models;

namespace UserManagement.Repository
{
    public interface IUserServices
    {
        Task<List<Users>> GetUsers();
        Task<Users> GetUsersById(int id);
        Task<bool> AddUser(Users user);


       

    }
}
