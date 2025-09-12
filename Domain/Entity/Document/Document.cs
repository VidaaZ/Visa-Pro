using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
  public  class Document
    {
        public Guid Id { get; set; }

        public Guid VisaApplicationId { get; set; }
        public VisaApplication VisaApplication { get; set; } = default!;

        [MaxLength(64)]
        public string DocumentType { get; set; } = default!;
        [MaxLength(512)]
        public string FileUrl { get; set; } = default!;
        [MaxLength(128)]
        public string? MimeType { get; set; }
        public long? SizeBytes { get; set; }

        public bool IsVerified { get; set; }
        public Guid? VerifiedByUserId { get; set; }
        public ApplicationUser? VerifiedByUser { get; set; }
        public DateTime? VerifiedAt { get; set; }

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    }
}
