using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public  class ApplicationType
    {
        public Guid Id { get; set; }

        [MaxLength(64)]
        public string Code { get; set; } = default!;
        [MaxLength(128)]
        public string Name { get; set; } = default!;
        [MaxLength(2)]
        public string? DefaultCountry { get; set; }
        [MaxLength(256)]
        public string? Description { get; set; }

       public ICollection<VisaApplication> VisaApplications { get; set; } = new List<VisaApplication>();

    }
}
