namespace Gestão_Administrativa.Domain.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? SubscriptionTypeId { get; set; }
        public decimal Price { get; set; }
        public string? Up { get; set; }
        public string? Down { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<SubscriptionContractModel> SubscriptionContracts { get; set; }


    }
}
