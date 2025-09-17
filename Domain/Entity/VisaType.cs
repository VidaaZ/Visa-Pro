using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class VisaType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Title { get; set; }

    }
}
