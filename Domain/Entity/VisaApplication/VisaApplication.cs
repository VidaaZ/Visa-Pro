using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
  public  class VisaApplication
    {
        public Guid Id { get; set; }


        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = default!;


        public Guid ApplicationTypeId { get; set; }
        public ApplicationType ApplicationType { get; set; } = default!;

        [MaxLength(2)]
        public string CountryCode { get; set; } = "CA";


        public Guid? AssignedOfficerUserId { get; set; }
        public ApplicationUser? AssignedOfficerUser { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? SubmittedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Document> Documents { get; set; } = new List<Document>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
