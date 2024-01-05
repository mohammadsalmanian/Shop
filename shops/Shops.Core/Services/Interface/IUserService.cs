
using Shops.DataLayer.Entitys.Account;

namespace Shops.Core.Services.Interface
{
    public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUser();
        Task<List<User>> GetActiveUsers();
        Task<User> GetUserById(long Id);
        Task AddUser(User user);
        Task UpdateUser(User user); 
        Task RemoveUser(User user);
        Task RemoveUserById(long Id);
    }
}
