using NineLivesCatRescue.Managers;
using NineLivesCatRescueLibrary;
using NineLivesCatRescueLibrary.ApiClients;
using NineLivesCatRescueLibrary.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RescueGroupsApiClient>();
builder.Services.AddScoped<SubmitApplicationApiClient>();
builder.Services.AddScoped<NineLivesStateManagementModel>();
builder.Services.AddScoped<RescueGroupsManager>();

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