using Shared.Domain.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Domain.Models
{
    public class BaseModel:IBaseModel<int?>
    {
        public int? Id { get; set; }
    }
}
