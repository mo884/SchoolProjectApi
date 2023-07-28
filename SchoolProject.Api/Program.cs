using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Database;
using SchoolProject.Infrustructure;
using SchoolProject.Service;
using SchoolProject.Core;
using SchoolProject.Infrustructure.Repesiratories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection SQL
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});


//Dependancy Injection

builder.Services.AddInfrustructureDependencies();
builder.Services.AddServiceDependencies();
builder.Services.AddCoreDependencie();


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
