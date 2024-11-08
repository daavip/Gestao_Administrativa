namespace Gestão_Administrativa.Models
{
    public class StatusContactModel
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public ICollection<ContractModel> Contracts { get; set; }
    }
}
