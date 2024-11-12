namespace Gestão_Administrativa.Domain.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required string Type { get; set; }
        public required decimal Price { get; set; }
        public string Up { get; set; } = string.Empty;
        public string Down { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }


    }
}
