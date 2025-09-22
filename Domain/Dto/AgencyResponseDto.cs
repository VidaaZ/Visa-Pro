using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
   public class AgencyResponseDto
    {
        public string Name { get; set; }

        public string NameEn { get; set; }

        public string LegalCode { get; set; }

        public string RegistrationNo { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPersonRole { get; set; }

        public string ContactPersonPhone { get; set; }

        public string ContactPersonEmail { get; set; }

        public DateTime EstablishedDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int CountryId { get; set; }
    }
}
