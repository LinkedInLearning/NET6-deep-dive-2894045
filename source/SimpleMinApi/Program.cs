using DataLib.Data;
using DataLib.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ToDoRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


// add minimal API code here...

// or refactor into other classes (when api grows).

app.MapGet (pattern: "/todo-list",handler: ([FromServices] ToDoRepository repo) => {
	return repo.GetAll().ToAsyncEnumerable<ToDoItem>();
});

app.MapGet(pattern: "/todo-list/{id}", handler: ([FromServices] ToDoRepository repo, long id) => {
	var toDoItem = repo.GetById(id);
	return toDoItem is not null ? Results.Ok(toDoItem) : Results.NotFound();
});

app.MapPost( "/todo-list",  ([FromServices] ToDoRepository repo, ToDoItem item) => {
	repo.Create(item);
	return Results.Created($"/todo-list/{item.Id}", item);
});

app.MapPut("/todo-list/{id}", ([FromServices] ToDoRepository repo, long id, ToDoItem updatedItem) => {
	var toDoItem = repo.GetById(id);
	if (updatedItem is null)
	{
		return Results.NotFound();
	}
	repo.Update(id, updatedItem);
	return Results.Ok(updatedItem);
});

app.Run();
