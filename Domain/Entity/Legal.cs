using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Legal:Party
    {

        public string Name { get; set; }
        public string NameEn { get; set; }
        public string LegalCode { get; set; }
        public string RegistrationNo { get; set; }
        public DateTime EstablishedDate { get; set; }
    }
}
