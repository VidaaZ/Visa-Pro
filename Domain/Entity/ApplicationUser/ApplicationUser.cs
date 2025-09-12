using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Entity
{
  public  class ApplicationUser
    {
        public Guid Id { get; set; }

        [MaxLength(256)]
        public string Email { get; set; } = default!;

        [MaxLength(128)]
        public string FirstName { get; set; }

        [MaxLength(128)]
        public string LastName { get; set; }


       public Profile? Profile { get; set; }
        public ICollection<VisaApplication> VisaApplications { get; set; } = new List<VisaApplication>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    }
}
