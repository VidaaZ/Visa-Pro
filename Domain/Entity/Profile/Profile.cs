using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Profile
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = default!;

        [MaxLength(128)]
        public string FirstName { get; set; } = default!;
        [MaxLength(128)]
        public string LastName { get; set; } = default!;
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(32)] public string? Phone { get; set; }
        [MaxLength(2)] public string? CountryOfCitizenship { get; set; }
        [MaxLength(64)] public string? NationalId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
