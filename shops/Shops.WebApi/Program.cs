using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Shops.Core.Services.Implementation;
using Shops.Core.Services.Interface;
using Shops.DataLayer.Context;
using Shops.DataLayer.Entitys.Account;
using Shops.DataLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AngularEshopDbContext>(optiion =>
{
    var connection = "Development:Developer";
    optiion.UseSqlServer(builder.Configuration.GetConnectionString(connection));
});

//builder.Services.AddScoped<IGenericRepository<User>,GenericRepository<User>>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISliderService, SliderService>();
//builder.Services.AddScoped<IUserService, UserService>();
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

app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions() // for files in content folder  
{
    FileProvider = new PhysicalFileProvider(
Path.Combine(Directory.GetCurrentDirectory(), "Rote"))   
});

app.Run();
