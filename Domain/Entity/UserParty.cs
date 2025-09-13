using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class UserParty
    {   //N to N
        public int UserId { get; set; }
        public User User { get; set; }
        public int PartyId { get; set; }
        public Party Party { get; set; }
    }
}
