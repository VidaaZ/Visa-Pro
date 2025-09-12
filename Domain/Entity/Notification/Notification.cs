using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Notification
    {
        public Guid Id { get; set; }


        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = default!;

        public Guid? VisaApplicationId { get; set; }
        public VisaApplication? VisaApplication { get; set; }


        [MaxLength(160)]
        public string? Subject { get; set; }
        [MaxLength(4000)]
        public string Body { get; set; } = default!;

        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? SentAt { get; set; }
        public DateTime? ReadAt { get; set; }

        [MaxLength(128)] public string? ProviderMessageId { get; set; }

    }
}
