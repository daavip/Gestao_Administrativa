namespace Gestão_Administrativa.Domain.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }

        public List<CustomerModel> Customers { get; set; }
        public List<ContractModel> Contracts { get; set; }
    }
}
