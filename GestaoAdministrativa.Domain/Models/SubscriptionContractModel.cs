namespace Gestão_Administrativa.Domain.Models
{
    public class SubscriptionContractModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int SubscriptionId { get; set; }


        public ContractModel Contract { get; set; }
        public SubscriptionModel Subscription { get; set; }

    }
}
