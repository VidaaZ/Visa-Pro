using Domain.Dto;

namespace Domain.Service.Agency
{
    public interface IAgencyService
    {
        Task<AgencyResponseDto> CreateAgencyAsync(AgencyRequestDto dto);
        Task<IEnumerable<AgencyResponseDto>> GetAgenciesAsync();
        Task<AgencyResponseDto> UpdateAgencyAsync(AgencyRequestDto dto, int id);
        void Delete(int id);
    }
}
