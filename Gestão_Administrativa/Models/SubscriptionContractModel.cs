namespace Gestão_Administrativa.Models
{
    public class SubscriptionContractModel
    {
        public int Id { get; set; }
        public int IdContract { get; set; }
        public int SubscriptionId { get; set; }


        public ContractModel Contract { get; set; }
        public SubscriptionModel Subscription { get; set; }

    }
}
