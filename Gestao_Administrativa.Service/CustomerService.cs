using Gestao_Administrativa.Domain.Interface.Service;
using Gestao_Administrativa.Domain.Models;
using Gestao_Administrativa.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Service
{
    public class CustomerService : BaseService<CustomerModel, int?>, ICustomerService
    {
        public CustomerService(SubscriptionManagementDBContext db) : base(db)
        {
        }

        public override int Update(CustomerModel model)
        {
            VerificaContatos(model);
            return base.Update(model);
        }

        public override Task<int> UpdateAsync(CustomerModel model)
        {
            VerificaContatos(model);
            return base.UpdateAsync(model);
        }

        private void VerificaContatos(CustomerModel model)
        {
            var cliente = Get().AsNoTracking().Where(x => x.Id == model.Id).Include(x => x.Contacts).FirstOrDefault();

            var contatos = cliente.Contacts.Where(x => !model.Contacts.Select(a => a.Id).ToList().Contains(x.Id)).ToList();

            foreach (var c in contatos)
            {
                model.Contacts.Add(c);
                _db.Entry(c).State = EntityState.Deleted;
            }
        }
    }
}
