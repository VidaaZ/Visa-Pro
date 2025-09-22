using Domain.Mapper;
using Domain.Service;
using Domain.ViewModel.Admin;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Dashboard.Admin
{
    [ApiController]
    [Route("api/dashboard/admin/")]
    public class AdminController:ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUserAsync(CreateUserViewModel viewModel)
        {
            try
            {
                var result = await _adminService.CreateAdminAsync(AdminMapper.ToDto(viewModel));
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
