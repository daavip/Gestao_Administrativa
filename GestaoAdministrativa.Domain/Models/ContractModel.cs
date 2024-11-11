namespace Gestão_Administrativa.Domain.Models
{
    public class ContractModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public int EquipmentId { get; set; }
        public int StatusCtId { get; set; }
        public DateTime CreatedAt { get; set; }


        public CustomerModel Customer { get; set; }
        public AddressModel Address { get; set; }
    }
}
