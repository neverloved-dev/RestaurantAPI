using RestaurantCRUD.Services.Interfaces;
using RestaurantCRUD.Services;
using RestaurantCRUD.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMealsService, MealsService>();
builder.Services.AddScoped<IDrinksService,DrinksService>();
builder.Services.AddScoped<IOrderService,OrdersService>();
builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<RestaurantDbContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MainConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
