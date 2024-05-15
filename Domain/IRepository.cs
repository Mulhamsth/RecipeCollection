namespace Domain;

public interface IRepository<TEntity>
{
   public Task<List<TEntity>> Get();
   public Task<TEntity> Get(int id);
   public Task<TEntity> POST(TEntity t);
   public Task<TEntity> PUT(TEntity t);
   public Task Delete(TEntity t); 
}