WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add https configuration in development

if (builder.Environment.IsDevelopment())
{
    builder.WebHost.UseKestrel(options =>
    {
        options.ListenLocalhost(5500);
        // Set HTTPS port
        options.ListenLocalhost(
            5501,
            listenOptions =>
            {
                listenOptions.UseHttps();
            }
        );
    });
}

// Use lower-case endpoints

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend API");
        c.RoutePrefix = string.Empty;
    });

app.UseAuthorization();

app.MapControllers();

app.Run();
