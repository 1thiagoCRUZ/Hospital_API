using Microsoft.EntityFrameworkCore;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IRepositories;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Interfaces.IServices;
using SistemaGerenciamentoAlmoxarifado.Hospital.Business.Services;
using SistemaGerenciamentoAlmoxarifado.Hospital.Data.Contexts;
using SistemaGerenciamentoAlmoxarifado.Hospital.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)
    ));
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
