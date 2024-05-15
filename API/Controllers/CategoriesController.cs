using Domain;
using Model.Entities;

namespace API.Controllers;

public class CategoriesController : GenericController<Category>
{
    public CategoriesController(RepositoryBase<Category> repository) : base(repository)
    {
    }
}