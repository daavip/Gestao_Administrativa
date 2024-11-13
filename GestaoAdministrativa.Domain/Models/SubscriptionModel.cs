using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class SubscriptionModel : BaseModel
    {
        public int? IdSubscriptionType { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string? Up { get; set; }
        public string? Down { get; set; }
        public DateTime CreatedAt { get; set; }
        public SubscriptionTypeModel SubscriptionType { get; set; }
        public List<SubscriptionContractModel> Contracts { get; set; }
    }
}
