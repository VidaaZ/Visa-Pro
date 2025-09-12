using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Appointment
    {
        public Guid Id { get; set; }


        public Guid VisaApplicationId { get; set; }
        public VisaApplication VisaApplication { get; set; } = default!;

        public Enums.AppointmentType Type { get; set; } = Enums.AppointmentType.Biometrics;
        public Enums.AppointmentStatus Status { get; set; } = Enums.AppointmentStatus.Booked;

        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }

        [MaxLength(256)] public string? Location { get; set; }
        [MaxLength(512)] public string? Notes { get; set; }

    }
}
