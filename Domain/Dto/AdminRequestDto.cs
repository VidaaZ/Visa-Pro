using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
   public class AdminRequestDto:PartyRequestDto
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public PartyRequestDto Party { get; set; }

    }
}
