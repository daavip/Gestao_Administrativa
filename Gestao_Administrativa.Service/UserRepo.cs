using Gestao_Administrativa.Domain.Interface;
using Gestao_Administrativa.Domain.Models;
using Gestao_Administrativa.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Gestao_Administrativa.Service
{
    public class UserRepo : IUserRepo
    {
        private readonly SubscriptionManagementDBContext _dbContext;
        public UserRepo(SubscriptionManagementDBContext subscriptionManagementDBContext)
        {
            _dbContext = subscriptionManagementDBContext;
        }
        public async Task<List<CustomerModel>> SearchAllUsers()
        {
            return await _dbContext.Customer.ToListAsync();
        }

        public async Task<CustomerModel> SearchId(int id)
        {
            return await _dbContext.Customer.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<CustomerModel> Add(CustomerModel user)
        {
            await _dbContext.Customer.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<CustomerModel> Update(CustomerModel user, int id)
        {
            CustomerModel userById = await SearchId(id);

            if(userById == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados");
            }

            userById.Name = user.Name;

            await _dbContext.Customer.AddAsync(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }

        public async Task<bool> Delete(int id)
        {
            CustomerModel userById = await SearchId(id);

            if (userById == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no banco de dados");
            }

            await _dbContext.Customer.AddAsync(userById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
