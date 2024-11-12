namespace Gestão_Administrativa.Domain.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public required string ContactInfo { get; set; }
        public required string ContactType { get; set; }
    }
}
