namespace Gestão_Administrativa.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string? ContactInfo { get; set; }
        public string? ContactType { get; set; }

        public ICollection<UserModel> Users { get; set; }
    }
}
