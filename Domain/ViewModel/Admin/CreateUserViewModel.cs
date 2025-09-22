using Domain.Entity;

namespace Domain.ViewModel.Admin
{
    public class CreateUserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public PartyRequestViewModel Party { get; set; }
      
    }
}
