using DataLib.Data;
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

app.MapGet (pattern: "api/message",handler: ()=> "Return this message to client!");
app.MapGet(pattern: "api/hello", handler: SayHello);
app.Run();

 static string SayHello()
{
	return "Hello";
}