using DataAccess.Data;
using Domain.Repository.Auth;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Auth;

public class AuthRepository : IAuthRepository
{
    #region MyRegion

    private readonly ApplicationDbContext _db;

    #endregion

    #region Constructor

    public AuthRepository(ApplicationDbContext db)
    {
        this._db = db;
    }
    
    #endregion

    #region Methods

    public async Task<bool> LoginAsync(string userName, string passwordHash)
    {
        var result = await _db.Users
                .Where(item => item.IsActive == true &&
                                                   item.Username == userName &&
                                                   item.PasswordHash == passwordHash)
                .FirstOrDefaultAsync();
        if (result.Username != null)
            return true;
        return false;
    }

    #endregion

}