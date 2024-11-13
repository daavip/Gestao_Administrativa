using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class ContractModel : BaseModel
    {
        public int IdStatus { get; set; }
        public int IdCustomer { get; set; }
        public int IdSubscription { get; set; }
        public int IdEquipment { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Discount { get; set; }
        public decimal Increase { get; set; }
        public int DueDate { get; set; }

        public virtual StatusContractModel Status { get; set; }
        public virtual IList<CustomerContractModel> Customers { get; set; }
        public virtual IList<SubscriptionContractModel> Subscriptions { get; set; }
    }
}
