using Shared.Domain.Interface.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Shared.Domain.Interface.Service
{
    public interface IBaseService<TModel, TIdType> where TModel : class, IBaseModel<TIdType>
    {
        int Update(TModel model);
        
        Task<int> UpdateAsync(TModel model);

        int Insert(TModel model);
        
        Task<int> InsertAsync(TModel model);
        
        IQueryable<TModel> Get();
                
        IQueryable<TModel> Get(TIdType id);
                                
        IQueryable<TModel> Get(Expression<Func<TModel, bool>> predicate);
                
        int Delete(TIdType id);
        
        Task<int> DeleteAsync(TIdType id);
    }
}