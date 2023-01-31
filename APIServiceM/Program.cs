using APIServiceM.IServices;
using APIServiceM.Services;
using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IProductService, ProductService>();

//builder.Services.AddScoped<IOrderLogic, OrderLogic>();
//builder.Services.AddScoped<IOrderService, OrderService>();

//builder.Services.AddScoped<IAdminLogic, AdminLogic>();
//builder.Services.AddScoped<IAdminService, AdminService>();

   builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

var app = builder.Build();

    var newProduct = new ProductItem();
    newProduct.Name = "Producto de prueba";

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


