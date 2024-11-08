namespace Gestão_Administrativa.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string? Numero { get; set; }
        public string? CEP { get; set; }

        public ICollection<UserModel> Users { get; set; }
        public ICollection<ContractModel> Contracts { get; set; }
    }
}
