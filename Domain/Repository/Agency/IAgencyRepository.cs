using Domain.Entity;
namespace Domain.Repository.Agency
  
{
    public interface IAgencyRepository
    {
        Task<Entity.Agency> CreateAsync(Entity.Agency agency);
        Task<Entity.Agency?> GetByIdAsync(int id);
        Task<IEnumerable<Entity.Agency>> GetAllAsync();
        Task<Entity.Agency> UpdateAsync(Entity.Agency agency,int id);
         void Delete(Entity.Agency agency);
    }
}
