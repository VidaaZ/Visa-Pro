using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public ICollection<UserParty> UserParties { get; set; }
    }
}