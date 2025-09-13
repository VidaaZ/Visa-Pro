using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
