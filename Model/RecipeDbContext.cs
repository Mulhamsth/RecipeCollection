using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model;

public class RecipeDbContext : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    public RecipeDbContext()
    {
        
    }
    public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Host=10.0.0.20;Username=mulham;Password=mulsth12;Database=Recipes");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>()
            .HasMany(x => x.Categories)
            .WithMany(x => x.Recipes);
    }
}