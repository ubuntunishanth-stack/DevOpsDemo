var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () =>
{
    return "DevOpsDemo API is running successfully!!";
});

app.MapGet("/hello/{name}", (string name) =>
{
    return new
    {
        message = $"Hello {name}",
        status = "success"
    };
});

app.Run();
