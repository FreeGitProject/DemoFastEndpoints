using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Register FastEndpoints
builder.Services.AddFastEndpoints().SwaggerDocument(); //define a swagger document;

var app = builder.Build();



app.UseHttpsRedirection();


// Use FastEndpoints
app.UseFastEndpoints().UseSwaggerGen(); //add this;
app.Run();

