using Microsoft.EntityFrameworkCore;
using Warships.DAL.Context;
using Warships.DAL.Interfaces;
using Warships.DAL.Repositories;
using Warships.BLL.Interfaces;
using Warships.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=warships.db"));

// Реєстрація репозиторію
builder.Services.AddScoped(typeof(IRepository<>), typeof(WarshipRepository));

// Реєстрація CRUD сервісу
builder.Services.AddScoped(typeof(ICrudServiceAsync<>), typeof(WarshipService));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
