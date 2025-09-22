using DataAccess.Data;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Admin
{
    
  public  class AdminRepository:IAdminRepository
    {
        private readonly ApplicationDbContext _db;

        public AdminRepository(ApplicationDbContext db)
        {
           this._db = db;
        }

        public async Task<Domain.Entity.User> CreateAsync(Domain.Entity.User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            //TODO:Agencies should be gotten from Get Method
            return user;
        }
    }
}
