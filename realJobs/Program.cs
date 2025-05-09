using Logic.Interfaces;
using Logic;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service;
using Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<RealJobDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// add handler and services to DI
builder.Services.AddScoped<ICompanyHandler, CompanyHandler>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

// add RealJobDbContext to DI
builder.Services.AddScoped<IRealJobDbContext>(provider => provider.GetRequiredService<RealJobDbContext>());

// add auto matcher

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
//await DbSeeder.SeedAsync(app.Services);
app.Run();
