using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class CustomerAddressModel : BaseModel
    {
        public int IdCustomer { get; set; }
        public int IdAddress { get; set; }

        public virtual CustomerModel Customer { get; set; }
        public virtual AddressModel Address { get; set; }
    }
}