using Microsoft.EntityFrameworkCore;
using Shops.Core.Services.Interface;
using Shops.DataLayer.Entitys.Account;
using Shops.DataLayer.Repository;

namespace Shops.Core.Services.Implementation
{
    public class UserService : IUserService
    {

        #region constractor
        private IGenericRepository<User> userRepository;
        public UserService(IGenericRepository<User> Repository)
        {
             this.userRepository = Repository;
        }
        #endregion


        public async Task<List<User>> GetActiveUsers()
        {
            return await userRepository.GetEntityQuerys().Where(t => !t.IsDeleted).ToListAsync();
        }

        public async Task<List<User>> GetAllUser()
        {
            return await userRepository.GetEntityQuerys().ToListAsync();
        }

        public async Task<User> GetUserById(long Id)
        {
            return await userRepository.GetEntityById(Id);
        }
        public async Task AddUser(User user)
        {
            await userRepository.AddEntity(user);
            await userRepository.SaveChenges();
        }
        public async Task UpdateUser(User user)
        {
            userRepository.UpdateEntity(user);
            await userRepository.SaveChenges();
        }

        public async Task RemoveUser(User user)
        {
            userRepository.RemoveEntity(user);
            await userRepository.SaveChenges();
        }

        public async Task RemoveUserById(long Id)
        {
            await userRepository.RemoveEntity(Id);
        }        
        public void Dispose()
        {
            this.userRepository!.Dispose();
        }
    }
}
