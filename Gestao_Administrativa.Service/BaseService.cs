using Gestao_Administrativa.Repository.Data;
using Shared.Domain.Interface.Models;
using Shared.Domain.Interface.Service;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Gestao_Administrativa.Service
{
    public class BaseService<TModel, TIdType> : IBaseService<TModel, TIdType>
        where TModel : class, IBaseModel<TIdType>
    {
        public SubscriptionManagementDBContext _db;

        public BaseService(SubscriptionManagementDBContext db)
        {
            _db = db;
        }

        public IQueryable<TModel> Get(TIdType id)
        {
            return _db.Set<TModel>()
                .Where(p => p.Id.Equals(id))
                .AsQueryable();
        }


        public IQueryable<TModel> Get()
        {
            return _db.Set<TModel>().AsQueryable();
        }

        public IQueryable<TModel> Get(Expression<Func<TModel, bool>> predicate)
        {
            return _db.Set<TModel>().Where(predicate.Compile()).AsQueryable();
        }

        public virtual int Insert(TModel model)
        {
            _db.Add<TModel>(model);

            return _db.SaveChanges();
        }

        public virtual async Task<int> InsertAsync(TModel model)
        {
            await _db.AddAsync<TModel>(model);

            return await _db.SaveChangesAsync();
        }

        public virtual int Update(TModel model)
        {
            _db.Update<TModel>(model);

            return _db.SaveChanges();
        }

        public virtual async Task<int> UpdateAsync(TModel model)
        {
            _db.Update<TModel>(model);

            return await _db.SaveChangesAsync();
        }

        public virtual int Delete(TIdType id)
        {
            TModel model = Get(id).FirstOrDefault();

            if (model != null)
            {
                _db.Entry<TModel>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                return _db.SaveChanges();
            }

            return -1;
        }

        public virtual async Task<int> DeleteAsync(TIdType id)
        {
            TModel model = Get(id).FirstOrDefault();

            if (model != null)
            {
                _db.Entry<TModel>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

                return await _db.SaveChangesAsync();
            }

            return -1;
        }
    }
}
