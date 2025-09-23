using Domain.Repository.Auth;
using Domain.Service;

namespace Business.Service.Auth;

public class AuthService : IAuthService
{
    #region Properties

    private readonly IAuthRepository _authRepository;

    #endregion
    
    #region Constructor 
    
    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }
    
    #endregion
    
    #region Methods
    
    //TODO: Password hash
    public Task<bool> LoginAsync(string userName, string password) =>
        _authRepository.LoginAsync(userName, password);
    
    #endregion
}