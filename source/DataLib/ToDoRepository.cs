using DataLib.Models;
using System.Linq;

namespace DataLib.Data {
	public class ToDoRepository {

		public ToDoRepository() {
			ToDoItem toDoItem = new ToDoItem { Id = 1, IsComplete = false, Name = "Send soundtrack proposal to Hans." };
			_toDoList.Add(toDoItem.Id, toDoItem);
			toDoItem = new ToDoItem { Id = 2, IsComplete = true, Name = "Bake whole wheat bread" };
			_toDoList.Add(toDoItem.Id, toDoItem);
			toDoItem = new ToDoItem { Id = 3, IsComplete = false, Name = "Buy guitar strings" };
			_toDoList.Add(toDoItem.Id, toDoItem);
			toDoItem = new ToDoItem { Id = 4, IsComplete = false, Name = "Record backing vocals" };
			_toDoList.Add(toDoItem.Id, toDoItem);
		}


		private readonly Dictionary<long, ToDoItem> _toDoList = new();
		public void Create(ToDoItem item) {
			if (_toDoList.ContainsKey(item.Id))
			{
				var highestId = _toDoList.Max(x => x.Value.Id) + 1;
				item.Id = highestId;
			}
			_toDoList.Add(item.Id, item);
		}
		public void Update(long id,  ToDoItem item) {
			if (_toDoList.ContainsKey(id))
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
			if (_toDoList.ContainsKey(id)==false)
			{
				return null;
			}
			return _toDoList[id];
		}

	}
}
