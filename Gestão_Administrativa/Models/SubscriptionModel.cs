using Gestão_Administrativa.Enums;

namespace Gestão_Administrativa.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public StatusSubscription Status { get; set; }
    }
}
