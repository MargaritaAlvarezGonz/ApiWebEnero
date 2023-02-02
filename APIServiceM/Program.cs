using APIServiceM.IServices;
using APIServiceM.Services;
using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IOrderLogic, OrderLogic>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUserLogic, UserLogic>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IPersonLogic, PersonLogic>();
builder.Services.AddScoped<IPersonService, PersonService>();

builder.Services.AddScoped<IBuyerLogic, BuyerLogic>();
builder.Services.AddScoped<IBuyerService, BuyerService>();

builder.Services.AddScoped<ISecurityLogic, SecurityLogic>();
builder.Services.AddScoped<ISecurityService, SecurityService>();



builder.Services.AddDbContext<ServiceContext>(
        options => options.UseSqlServer("name=ConnectionStrings:ServiceContext"));

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


