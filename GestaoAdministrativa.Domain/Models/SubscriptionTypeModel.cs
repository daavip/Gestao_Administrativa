using Gestão_Administrativa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gestao_Administrativa.Domain.Models
{
    public class SubscriptionTypeModel
    {
        public int Id { get; set; }
        public string? Description { get; set; }


        public List<SubscriptionModel> Subscriptions { get; set; }
    }
}
