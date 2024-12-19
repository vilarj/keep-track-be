using keep_track_be.Context;
using keep_track_be.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<KeepTrackContext>(options => options.UseNpgsql(builder.Configuration["connString"]));
builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();