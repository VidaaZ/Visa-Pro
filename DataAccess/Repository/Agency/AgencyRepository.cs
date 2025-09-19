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
            return agency;
        }

        public Task<Domain.Entity.Agency?> GetByIdAsync(int id) =>
            _db.Agencies.FirstOrDefaultAsync(a => a.Id == id);

        public async Task<IEnumerable<Domain.Entity.Agency>> GetAllAsync() =>
            await _db.Agencies.ToListAsync();

        public async Task<Domain.Entity.Agency> UpdateAsync(Domain.Entity.Agency agency)
        {
            var existing = await _db.Agencies.FirstOrDefaultAsync(a => a.Id == agency.Id);
            if (existing is null) throw new KeyNotFoundException("Agency not found.");

            _db.Entry(existing).CurrentValues.SetValues(agency);
            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task DeleteAsync(Domain.Entity.Agency agency)
        {
            _db.Agencies.Remove(agency);
            await _db.SaveChangesAsync();
        }
    }
}
