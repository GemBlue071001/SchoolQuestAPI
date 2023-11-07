using Domain.Enums;
namespace Domain.Models
{
    public class User : Base
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? HighestScore { get; set; }
        public UserRole Role { get; set; }

        //Property Navigation
        public List<Attempt> Attempts { get; set; }
    }
}
