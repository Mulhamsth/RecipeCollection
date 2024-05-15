using Model;
using Model.Entities;

namespace Domain;

public class CategoriesRepository : RepositoryBase<Category>
{
    public CategoriesRepository(RecipeDbContext context) : base(context)
    {
    }
}