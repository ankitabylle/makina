using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Makina Platform API",
        Version = "v1",
        Description = "An API to perform Makina Platform API",
        TermsOfService = new Uri("https://makina.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Rajesh Nagaral",
            Email = "rajesh@crsolutions.in",
            Url = new Uri("https://www.makina.com/"),
        },
        License = new OpenApiLicense
        {
            Name = "Makina Group LLC.",
            Url = new Uri("https://www.makina.com/"),
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
    });
});
app.Run();
