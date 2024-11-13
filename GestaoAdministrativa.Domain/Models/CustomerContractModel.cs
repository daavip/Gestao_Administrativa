using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class CustomerContractModel : BaseModel
    {
        public int IdCustomer { get; set; }
        public int IdContract { get; set; }

        public virtual CustomerModel Customer { get; set; }
        public virtual ContractModel Contract { get; set; }
    }
}
