namespace Gestão_Administrativa.Domain.Models
{
    public class UserModel
    {
        public int Id { get ; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CpfCnpj { get; set; }
        public int IdContact { get; set; }
        public int IdAddress { get; set; }


        public ContactModel Contact { get; set; }
        public AddressModel Address { get; set; }
    }
}
