using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class StatusContractModel : BaseModel
    {
        public string Status { get; set; }
        public virtual IList<ContractModel> Contracts { get; set; }
    }
}
