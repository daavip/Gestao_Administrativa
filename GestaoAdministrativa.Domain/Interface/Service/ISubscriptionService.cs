using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestao_Administrativa.Domain.Models;
using Shared.Domain.Interface.Service;

namespace Gestao_Administrativa.Domain.Interface.Service
{
    public interface ISubscriptionService : IBaseService<SubscriptionModel, int?>
    {
    }
}
