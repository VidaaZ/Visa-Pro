using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Payment
    {
        public Guid Id { get; set; }

        public Guid VisaApplicationId { get; set; }
        public VisaApplication VisaApplication { get; set; } = default!;

        public decimal Amount { get; set; }
        [MaxLength(3)]
        public string Currency { get; set; } = "USD";

        [MaxLength(64)]
        public string Provider { get; set; } = "Stripe";
        [MaxLength(128)]
        public string? ProviderTxnId { get; set; }

        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? PaidAt { get; set; }

    }
}
