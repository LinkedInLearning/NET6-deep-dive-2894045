using DataLib.Models;
using System.Linq;

namespace DataLib.Data {
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
	//	private readonly ConcurrentDictionary<long, ToDoItem> _toDoListOld = new();	

		private readonly Dictionary<long, ToDoItem> _toDoList = new();
    public void Create(ToDoItem item)
    {
      if (_toDoList.ContainsKey(item.Id))
      {
				var highestId = _toDoList.Max(x=>x.Value.Id) +1;
				item.Id = highestId;
      }
			_toDoList.Add(item.Id,item);
    }
		public void Update(ToDoItem item)
		{
			if (_toDoList.ContainsKey(item.Id))
			{
				_toDoList[item.Id] = item;

			}
		}
		public void Delete(long id) {
		_toDoList.Remove(id);
		}
		public List<ToDoItem> GetAll() {
			return _toDoList.Values.ToList();
		}
		public ToDoItem GetById(long id) {
			return _toDoList[id];
		}

	}
}
