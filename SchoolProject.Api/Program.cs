using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrustructure.Abstraction;
using SchoolProject.Infrustructure.Database;
using SchoolProject.Infrustructure;
using SchoolProject.Service;
using SchoolProject.Core;
using SchoolProject.Infrustructure.Repesiratories;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Connection SQL
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});

#endregion


#region Dependancy Injection
builder.Services.AddInfrustructureDependencies();
builder.Services.AddServiceDependencies();
builder.Services.AddCoreDependencie();

#endregion

#region locallization
builder.Services.AddControllersWithViews();
builder.Services.AddLocalization(opt => opt.ResourcesPath = "");
builder.Services.Configure<RequestLocalizationOptions>(option =>
{
	List<CultureInfo> SupportedCulture = new List<CultureInfo>()
	{
		new CultureInfo("en-US"),
		
		new CultureInfo("ar-EG"),
	};
	option.DefaultRequestCulture = new RequestCulture("ar-EG");
	option.SupportedCultures = SupportedCulture;
	option.SupportedUICultures = SupportedCulture;
});
#endregion



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
