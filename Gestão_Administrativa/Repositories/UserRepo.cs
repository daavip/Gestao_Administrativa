using Gestão_Administrativa.Data;
using Gestão_Administrativa.Models;
using Gestão_Administrativa.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Gestão_Administrativa.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly SubscriptionManagementDBContext _dbContext;
        public UserRepo(SubscriptionManagementDBContext subscriptionManagementDBContext)
        {
            _dbContext = subscriptionManagementDBContext;
        }
        public async Task<List<UserModel>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> SearchId(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> Add(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<UserModel> Update(UserModel user, int id)
        {
            UserModel userById = await SearchId(id);

            if(userById == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            await _dbContext.Users.AddAsync(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }

        public async Task<bool> Delete(int id)
        {
            UserModel userById = await SearchId(id);

            if (userById == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados");
            }

            await _dbContext.Users.AddAsync(userById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
