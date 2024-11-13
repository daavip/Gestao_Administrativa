using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class CustomerModel : BaseModel
    {
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public int IdAddress { get; set; }
        public int? IdContact {  get; set; }
        public int? IdContract {  get; set; }
        public virtual IList<CustomerAddressModel> Addresses { get; set; }
        public virtual IList<CustomerContactModel> Contacts { get; set; }
        public virtual IList<CustomerContractModel> Contracts { get; set; }
    }
}
