using NineLivesCatRescue.Managers;
using NineLivesCatRescueLibrary;
using NineLivesCatRescueLibrary.ApiClients;
using NineLivesCatRescueLibrary.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.WriteTo.File("/Users/whitneyatkinson/Documents/logs.txt", rollingInterval: RollingInterval.Day)
	.CreateLogger();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RescueGroupsApiClient>();
builder.Services.AddScoped<SubmitApplicationApiClient>();
builder.Services.AddScoped<NineLivesStateManagementModel>();
builder.Services.AddScoped<RescueGroupsManager>();

builder.Services.AddCors(policyBuilder =>
	policyBuilder.AddDefaultPolicy(policy =>
		policy.WithOrigins("*")
			.AllowAnyHeader())
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();