namespace Domain.Repository.Auth;

public interface IAuthRepository
{
    Task<bool> LoginAsync(string userName, string passwordHash);
}