using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Domain.Interface
{
    public interface IUserRepo
    {
        Task<List<CustomerModel>> SearchAllUsers();
        Task<CustomerModel> SearchId(int id);
        Task<CustomerModel> Add(CustomerModel user);
        Task<CustomerModel> Update(CustomerModel user, int id);
        Task<bool> Delete(int id);
    }
}
