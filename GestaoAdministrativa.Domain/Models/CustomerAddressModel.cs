using Gestão_Administrativa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Administrativa.Domain.Models
{
    public class CustomerAddressModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public CustomerModel Customer { get; set; }
        public AddressModel Address { get; set; }
    }
}
