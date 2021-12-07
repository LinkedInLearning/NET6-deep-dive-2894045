namespace SimpleFullApi.Models;

public record ToDoItem {
	public long Id { get; set; }
	public string? Name { get; set; }
	public bool IsComplete { get; set; }
}

