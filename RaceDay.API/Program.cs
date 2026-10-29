
using Microsoft.EntityFrameworkCore;
using RaceDay.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Register the RaceDay database connection.
builder.Services.AddDbContext<RaceDayContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("RaceDayConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
