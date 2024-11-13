using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class AddressModel : BaseModel
    {
        public int? IdCustomer {  get; set; }
        public int Number { get; set; }
        public int CEP { get; set; }

        public virtual IList<CustomerAddressModel> Customers { get; set; }

    }
}
