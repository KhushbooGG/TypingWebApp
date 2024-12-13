namespace TypingWebApp.Models
{
    public class Users
    {
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
        public int? RoleId { get; set; }
    }
}
