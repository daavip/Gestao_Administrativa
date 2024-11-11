using Gestão_Administrativa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class CustomerContractModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ContractId { get; set; }

        public CustomerModel Customer { get; set; }
        public ContractModel Contract { get; set; }
    }
}
