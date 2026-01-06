using Asp.Versioning;
using IDP.Application.Handler.Command.User;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddMediatR(typeof(UserHandler).GetTypeInfo().Assembly);
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0); // ورژن پیش‌فرض
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true; // اگر ورژن ذکر نشد، از پیش‌فرض استفاده کن


    // انتخاب روش خواندن ورژن (در اینجا هم از هدر و هم از کوئری استرینگ)
    options.ApiVersionReader = ApiVersionReader.Combine(
       // new QueryStringApiVersionReader("api-version"),
       new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version")
    );
})
.AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'V"; // فرمت نام‌گذاری ورژن‌ها در Swagger
    options.SubstituteApiVersionInUrl = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
