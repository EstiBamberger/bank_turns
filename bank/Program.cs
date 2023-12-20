using bank;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data;
using Solid.Data.Repositories;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<ICustomerRepositories, CustomersRepository>();
builder.Services.AddScoped<IOfficialsRepositories, OfficialsRepository>();
builder.Services.AddScoped<ITurnsRepositories, TurnsRepository>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOfficialsServices, OfficialService>();
builder.Services.AddScoped<ITurnsServices, TurnService>();



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
