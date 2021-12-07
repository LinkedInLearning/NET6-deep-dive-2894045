using Microsoft.AspNetCore.Mvc;
using SimpleFullApi.Data;
using SimpleFullApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleFullApi.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class ToDo : ControllerBase {
		// GET: api/<ToDo>
		[HttpGet]
		public Dictionary<long, SimpleFullApi.Models.ToDoItem> Get([FromServices] ToDoRepository repo) {

			return repo.GetAll();
	
		}

		// GET api/<ToDo>/5
		[HttpGet("{id}")]
		public ToDoItem Get(long id, [FromServices] ToDoRepository repo) {
			return repo.GetById(id);
		}

		// POST api/<ToDo>
		[HttpPost]
		public void Post([FromBody] string value) {
		}

		// PUT api/<ToDo>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value) {
		}

		// DELETE api/<ToDo>/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
		}
	}
}
