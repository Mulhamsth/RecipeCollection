using Model;
using Model.Entities;

namespace Domain;

public class RecipesRepository : RepositoryBase<Recipe>
{
    public RecipesRepository(RecipeDbContext context) : base(context)
    {
    }
}