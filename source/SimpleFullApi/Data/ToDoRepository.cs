using SimpleFullApi.Models;

namespace SimpleFullApi.Data {
	public class ToDoRepository {

		public ToDoRepository() {
			ToDoItem toDo = new ToDoItem { Id=1, IsComplete= false, Name= "Send soundtrack proposal to Hans." };
			_toDoList.Add(toDo.Id, toDo);
			toDo = new ToDoItem { Id = 2, IsComplete = true, Name = "Bake whole wheat bread" };
			_toDoList.Add(toDo.Id, toDo);
			toDo = new ToDoItem { Id = 3, IsComplete = false, Name = "Buy guitar strings" };
			_toDoList.Add(toDo.Id, toDo);
			toDo = new ToDoItem { Id = 4, IsComplete = false, Name = "Record backing vocals" };
			_toDoList.Add(toDo.Id, toDo);
		}
		private readonly Dictionary<long, ToDoItem> _toDoList = new();	

		public void Create(ToDoItem item) {
			if (_toDoList.)
			{

			}
		}
		public void Update(ToDoItem item) { }
		public void Delete(int id) { }
		public Dictionary<long, ToDoItem> GetAll() {
			return _toDoList;
		}
		public ToDoItem GetById(long id) {
			return _toDoList[id];
		}

	}
}
