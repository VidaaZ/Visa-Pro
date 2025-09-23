using Microsoft.AspNetCore.Mvc;
using Domain.Service;

namespace WebApi.Controllers.Dashboard.Auth;

[ApiController]
[Route("api/auth/")]
public class AuthController : ControllerBase
{
    #region
    
    private readonly IAuthService _authService;
    
    #endregion

    #region Constructor
    
    public AuthController(IAuthService authService)
    {
        this._authService = authService;
    }
    
    #endregion
    
    #region Methods
    
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LoginAsync(string userName, string password)
    {
        try
        {
            var result = await _authService.LoginAsync(userName, password);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);

        }
    }
    
    #endregion
}