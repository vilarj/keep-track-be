using keep_track_be.Context;
using keep_track_be.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<KeepTrackContext>(options => {}); // TODO: Need to connect to Postgresql
builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();