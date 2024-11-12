namespace Gestão_Administrativa.Domain.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public required int Numero { get; set; }
        public required int CEP { get; set; }
    }
}
