using Microsoft.AspNetCore.Mvc;
using DataLib.Data;
using DataLib.Models;
using System.Linq;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleFullApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDo : ControllerBase
{
  // GET: api/<ToDo>
  [HttpGet]
  public IAsyncEnumerable<ToDoItem> Get([FromServices] ToDoRepository repo)
  {

    return repo.GetAll().ToAsyncEnumerable<ToDoItem>();

  }

  // GET api/<ToDo>/5
  [HttpGet("{id}")]
  public IResult Get(long id, [FromServices] ToDoRepository repo)
  {
    var toDoItem = repo.GetById(id);
    return toDoItem is not null ? Results.Ok(toDoItem) : Results.NotFound();
  }

  // POST api/<ToDo> Create
  [HttpPost]
  public IResult Post([FromServices] ToDoRepository repo, ToDoItem item)
  {
    repo.Create(item);
    return Results.Created($"api/ToDo/{item.Id}", item);
  }

  // PUT api/<ToDo>/5
  [HttpPut("{id}")]
  public IResult Put([FromServices] ToDoRepository repo, long id,ToDoItem updatedItem)
  {
    var toDoItem = repo.GetById(id);
    if (updatedItem is null)
    {
      return Results.NotFound();
    }
    repo.Update(id,updatedItem);  
    return Results.Ok (updatedItem);
  }

  // DELETE api/<ToDo>/5
  [HttpDelete("{id}")]
  public IResult Delete([FromServices] ToDoRepository repo,long id)
  {
    repo.Delete(id);
    return Results.Ok();
  }
}

