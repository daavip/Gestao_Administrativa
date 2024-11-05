using Gestão_Administrativa.Models;

namespace Gestão_Administrativa.Repositories.Interface
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
