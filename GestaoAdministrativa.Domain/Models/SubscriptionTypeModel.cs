using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class SubscriptionTypeModel : BaseModel
    {
        public string? Description { get; set; }


        public List<SubscriptionModel> Subscriptions { get; set; }
    }
}
