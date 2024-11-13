﻿using Gestao_Administrativa.Domain.Interface.Service;
using Gestao_Administrativa.Domain.Models;
using Gestao_Administrativa.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Service
{
    public class ContractService : BaseService<ContractModel, int?>, IContractService
    {
        public ContractService(SubscriptionManagementDBContext db) : base(db)
        {
        }
    }
}
