using Domain.Dto;
using Domain.Entity;
using Domain.ViewModel.Admin;

namespace Domain.Mapper
{
    public static class AdminMapper
    {
        public static AdminRequestDto ToDto(this CreateUserViewModel viewModel)
        {
            return new AdminRequestDto
            {
                UserName = viewModel.Username,
                PasswordHash = viewModel.Password,
                Party = viewModel.Party.ToDto()
            };

        }
        public static PartyRequestDto ToDto(this PartyRequestViewModel viewModel)
        {
            return new PartyRequestDto
            {
                IsIndividual = viewModel.IsIndividual
            };
        }
        public static User ToEntity(AdminRequestDto d)
        {
            return new User
            {
                Username=d.UserName,
                PasswordHash=d.PasswordHash

            };
        }
        
    }
}

