using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class GenericController<TEntity> : ControllerBase where TEntity : class
{
   private RepositoryBase<TEntity> _repository;
   
   public GenericController(RepositoryBase<TEntity> repository)
   {
       _repository = repository;
   }
   
   [HttpGet]
   public async Task<List<TEntity>> Get()
   {
       return await _repository.Get();
   }
   
   [HttpGet("{id:int}")]
   public async Task<TEntity> Get(int id)
   {
       return await _repository.Get(id);
   }

   [HttpPost]
   public async Task<TEntity> Post(TEntity t)
   {
       return await _repository.POST(t);
   }

   [HttpPut]
   public async Task<TEntity> PUT(TEntity t)
   {
       return await _repository.PUT(t);
   }

   [HttpDelete]
   public async Task Delete(TEntity t)
   {
       await _repository.Delete(t);
   }
}