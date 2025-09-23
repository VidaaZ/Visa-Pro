using Domain.Dto;
using Domain.Mapper;
using Domain.Repository.Agency;
using Domain.Service.Agency;

namespace Business.Service.Agency
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;

        public AgencyService(IAgencyRepository agencyRepository)
        {
            this._agencyRepository = agencyRepository;
        }

        public async Task<AgencyResponseDto> CreateAgencyAsync(AgencyRequestDto dto)
        {
            try
            {
                var entity = AgencyMapper.ToEntity(dto);
                var created = await _agencyRepository.CreateAsync(entity);

                return AgencyMapper.ToResponseDto(created);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while creating the agency.", ex);
            }
        }

        public async Task<AgencyResponseDto> UpdateAgencyAsync(AgencyRequestDto dto, int id)
        {
            try
            {
                var existing = await _agencyRepository.GetByIdAsync(id)
                               ?? throw new KeyNotFoundException("Agency with the specified ID not found.");
                var updated = await _agencyRepository.UpdateAsync(AgencyMapper.ToEntity(dto), id);

                return AgencyMapper.ToResponseDto(updated);
            }
            catch (KeyNotFoundException) { throw; }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the agency.", ex);
            }
        }
        public async Task<IEnumerable<AgencyResponseDto>> GetAgenciesAsync()
        {
            try
            {
                var list = await _agencyRepository.GetAllAsync();
                return AgencyMapper.ToResponseDto(list);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while fetching agencies.");
            }
        }
        
        public void Delete(int id)
        {
            try
            {
                var agency =  _agencyRepository.GetByIdAsync(id).Result;
                if (agency is null)
                    throw new KeyNotFoundException("Agency with this id is not found.");
                agency.IsActive = false; 
                
                _agencyRepository.UpdateAsync(agency, id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the agency.", ex);
            }
        }
    }
}
