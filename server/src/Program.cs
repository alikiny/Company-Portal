global using System.ComponentModel.DataAnnotations;
global using System.Runtime.Serialization;
global using System.Text.Json.Serialization;

using server.src.Database;
using server.src.Middleware;
using server.src.Repository;
using server.src.Service;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add https configuration in development

if (builder.Environment.IsDevelopment())
{
    _ = builder.WebHost.UseKestrel(options =>
    {
        options.ListenLocalhost(5500);
        // Set HTTPS port
        options.ListenLocalhost(
            5501,
            listenOptions =>
            {
                _ = listenOptions.UseHttps();
            }
        );
    });
}

// Use lower-case endpoints

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

// Enable cors

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services
.AddScoped<ICompanyRepo, CompanyRepo>()
.AddScoped<ICompanyService, CompanyService>();

builder.Services.AddDbContext<DatabaseContext>();

builder.Services.AddTransient<ErrorHandlerMiddleware>();

WebApplication app = builder.Build();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend API");
        c.RoutePrefix = string.Empty;
    });

app.UseCors();

app.UseErrorHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
