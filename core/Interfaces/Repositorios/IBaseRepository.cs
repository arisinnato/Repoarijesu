namespace core.Interfaces.Repositorios
{
    public interface IBaseRepository<TEntity> where TEntity : class 
    {
        ValueTask<TEntity> GetByIAdsync(int id);
        Task<IEnumerable<TEntity>> GetALLAsync();
        void Remove(TEntity entidad);
        void RemoveRange(IEnumerable<TEntity> entidades);
        Task Update(TEntity entidad);
        Task AddAsync(TEntity entidad);
    }
}