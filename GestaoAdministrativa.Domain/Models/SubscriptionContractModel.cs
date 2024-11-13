using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class SubscriptionContractModel : BaseModel
    {
        public int IdContract { get; set; }
        public int IdSubscription { get; set; }

        public virtual ContractModel Contract { get; set; }
        public virtual SubscriptionModel Subscription { get; set; }
    }
}
