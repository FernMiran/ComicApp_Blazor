using ComicApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ComicApp.Infrastructure.Extensions;
using ComicApp.Application.Extensions;
using MediatR;
using ComicApp.Application.User.Commands;
using ComicApp.API.Middlewares;
using ComicApp.Contracts.User;
using Microsoft.AspNetCore.Mvc;
using ComicApp.Contracts.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ComicDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ComicConnection")));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Layers
builder.Services.AddInfrastructure();
builder.Services.AddApplication();

builder.Services.AddTransient<ExceptionMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// Minimal API: reducir complejidad en controladores, un endpoint -> una funcion
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapPost("/user", async Task<IResult> (IMediator mediator, [FromBody]CreateUserDTO createUserDTO) =>
{
    var user = await mediator.Send(new CreateUser()
    {
        Username = createUserDTO.Username,
        Password = createUserDTO.Password
    });

    if (!user.Success)
    {
        return TypedResults.BadRequest(new TaskResultDTO() { Success = false, Errors = user.ErrorMessages });
    }

    return TypedResults.Ok(new TaskResultDTO() { Success = true, Errors = new List<string>() });
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
