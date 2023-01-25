using Core.Base;
using Core.Employee.services;
using Core.EmployeeType.services;
using Core.Shop.services;
using Core.ShopEmployee.services;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<ChallengeContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Challenge"));
});

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IEmployeeTypeService, EmployeeTypeService>();
builder.Services.AddTransient<IShopService, ShopService>();
builder.Services.AddTransient<IShopEmployeeService, ShopEmployeeService>();

var app = builder.Build();

using(var scope  = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<ChallengeContext>();
        context.Database.Migrate();
    }catch(Exception e)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(e, "Ocurrio un error");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
