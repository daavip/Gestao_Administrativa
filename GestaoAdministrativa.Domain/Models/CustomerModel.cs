namespace Gestão_Administrativa.Domain.Models
{
    public class CustomerModel
    {
        public int Id { get ; set; }
        public required string Name { get; set; }
        public required string CpfCnpj { get; set; }

        public IList<ContactModel> Contacts { get; set; }
        public AddressModel Address { get; set; }

    }
}
