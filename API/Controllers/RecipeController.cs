using Domain;
using Model.Entities;

namespace API.Controllers;

public class RecipeController : GenericController<Recipe>
{
    public RecipeController(RepositoryBase<Recipe> repository) : base(repository)
    {
    }
}