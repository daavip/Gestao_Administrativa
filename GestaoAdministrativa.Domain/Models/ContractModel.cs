namespace Gestão_Administrativa.Domain.Models
{
    public class ContractModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdAddress { get; set; }
        public int StatusCtId { get; set; }
        public DateTime CreatedAt { get; set; }


        public UserModel User { get; set; }
        public AddressModel Address { get; set; }
        public StatusContactModel StatusContact { get; set; }
    }
}
