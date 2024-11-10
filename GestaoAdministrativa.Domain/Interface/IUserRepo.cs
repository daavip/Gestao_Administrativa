using Gestão_Administrativa.Domain.Models;

namespace Gestão_Administrativa.Domain.Interface
{
    public interface IUserRepo
    {
        Task<List<UserModel>> SearchAllUsers();
        Task<UserModel> SearchId(int id);
        Task<UserModel> Add(UserModel user);
        Task<UserModel> Update(UserModel user, int id);
        Task<bool> Delete(int id);
    }
}
