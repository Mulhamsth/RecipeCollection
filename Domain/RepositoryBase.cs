using Microsoft.EntityFrameworkCore;
using Model;

namespace Domain;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly RecipeDbContext _context;
    private readonly DbSet<TEntity> _table;

    protected RepositoryBase(RecipeDbContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }
    
    public async Task<List<TEntity>> Get()
    {
        return await _table.ToListAsync();
    }

    public async Task<TEntity> Get(int id)
    {
        return await _table.FindAsync(id);
    }

    public async Task<TEntity> POST(TEntity t)
    {
        await _table.AddAsync(t);
        await _context.SaveChangesAsync();
        return t;
    }

    public async Task<TEntity> PUT(TEntity t)
    {
        _table.Update(t);
        await _context.SaveChangesAsync();
        return t;
    }

    public async Task Delete(TEntity t)
    {
        _table.Remove(t);
        await _context.SaveChangesAsync();
    }

}