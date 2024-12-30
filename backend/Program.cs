using AspireSQLEFCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddSqlServerDbContext<ApplicationDbContext>("sqldata");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.UseHttpsRedirection();

app.Run();

public partial class Program;