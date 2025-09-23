namespace Domain.Service;

public interface IAuthService
{
    Task<bool> LoginAsync(string userName, string password);
}