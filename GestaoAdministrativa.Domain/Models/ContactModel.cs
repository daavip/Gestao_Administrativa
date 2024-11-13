using Shared.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class ContactModel : BaseModel
    {
        public string ContactInfo { get; set; }
        public string ContactType { get; set; }

        public virtual IList<CustomerContactModel> Customers { get; set; }
    }
}
