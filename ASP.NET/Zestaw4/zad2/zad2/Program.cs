var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/{param}", (string param) =>
{
    return $"Parametr: {param}";
});

app.MapGet("/{param:int}", (int param) =>
{
    return $"Parametr typu int: {param}";
});

app.MapGet("/{param:length(1,10)}", (string param) =>
{
    return $"Parametr z ograniczeniem długości: {param}";
});

app.MapGet("/{param:required}", (string param) =>
{
    return $"Parametr wymagany: {param}";
});

app.MapGet("/{param:regex(^\\d{{4}}$)}", (string param) =>
{
    return $"Parametr spełniający wyrażenie regularne: {param}";
});

app.Run();
