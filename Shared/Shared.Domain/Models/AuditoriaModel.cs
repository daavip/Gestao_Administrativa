using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Domain.Models
{
    public class AuditoriaModel : BaseModel
    {
        public string TableName { get; set; }

        public DateTime DateTime { get; set; }

        public string KeyValues { get; set; }

        public string OldValues { get; set; }

        public string NewValues { get; set; }

        public int User { get; set; }

        public string Operation { get; set; }
    }
}
