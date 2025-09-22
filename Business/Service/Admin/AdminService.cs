using Domain.Dto;
using Domain.Mapper;
using Domain.Repository;
using Domain.Service;

namespace Business.Service.Admin
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<bool> CreateAdminAsync(AdminRequestDto dto)
        {
            try
            {
                var entity = AdminMapper.ToEntity(dto);
                var created = _adminRepository.CreateAsync(entity);
                if (created != null)
                    return true;

                return false;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("An error occured while creating the user", ex);
            }
        }
    }
}
