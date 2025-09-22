using DataAccess.Data;
using Domain.Repository.Agency;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Agency
{
    public class AgencyRepository : IAgencyRepository
    {
        private readonly ApplicationDbContext _db;

        public AgencyRepository(ApplicationDbContext db)
        {
          this._db = db;
        }
        
        public async Task<Domain.Entity.Agency> CreateAsync(Domain.Entity.Agency agency)
        {
            await _db.Agencies.AddAsync(agency);     
            await _db.SaveChangesAsync();
            //TODO:Agencies should be gotten from Get Method
            return agency;
        }

        public Task<Domain.Entity.Agency> GetByIdAsync(int id) =>
            _db.Agencies.FirstOrDefaultAsync(a => a.Id == id);

        public async Task<IEnumerable<Domain.Entity.Agency>> GetAllAsync() =>
            await _db.Agencies.ToListAsync();

        public async Task<Domain.Entity.Agency> UpdateAsync(Domain.Entity.Agency agency,int id)
        {   
            var existing = await _db.Agencies.FirstOrDefaultAsync(a => a.Id == id);
            if (existing is null) throw new KeyNotFoundException("Agency not found.");
            agency.Id = id;
            _db.Entry(existing).CurrentValues.SetValues(agency);
            await _db.SaveChangesAsync();
            return existing;
        }

        public void Delete(Domain.Entity.Agency agency)
        {
            _db.Agencies.Remove(agency);
            _db.SaveChanges();
        }
    }
}
