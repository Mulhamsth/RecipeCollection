namespace Domain;

public interface IRepository<TEntity>
{
   public Task<TEntity> Get();
   public Task<TEntity> POST(); 
   public Task<TEntity> Delete(); 
}