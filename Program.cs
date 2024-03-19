var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/time", () => $"Current time is: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

app.Run();