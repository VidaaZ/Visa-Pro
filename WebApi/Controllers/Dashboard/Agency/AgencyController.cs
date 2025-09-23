
using Domain.Mapper;
using Domain.Service.Agency;
using Domain.ViewModel.Agency;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Dashboard.Agency
{
    [ApiController]
    [Route("api/dashboard/agency/")]
    public class AgencyController : ControllerBase
    {

        private readonly IAgencyService _agencyService;
        public AgencyController(IAgencyService agencyService)
        {
            this._agencyService = agencyService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAgencyAsync(AgencyRequestViewModel viewModel)
        {
            try
            {
                var result = await _agencyService.CreateAgencyAsync(AgencyMapper.ToDto(viewModel));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateAgencyAsync( [FromBody] AgencyRequestViewModel viewModel, int id)
        {
            try
            {
                var result = await _agencyService.UpdateAgencyAsync(AgencyMapper.ToDto(viewModel), id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAgencyAsync(int id)
        {
            try
            {
                _agencyService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getallagencies")]
        public async Task<IActionResult> GetAgenciesAsync()
        {
            try
            {
                var result = await _agencyService.GetAgenciesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
