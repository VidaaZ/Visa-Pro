using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum AppointmentType { Biometrics, Interview, Other }

    public enum AppointmentStatus { Booked, Completed, NoShow, Cancelled, Rescheduled }

    public enum PaymentStatus { Pending, Succeeded, Failed, Refunded }

}
