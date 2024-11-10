namespace Gestão_Administrativa.Domain.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<SubscriptionContractModel> SubscriptionContracts { get; set; }


    }
}
