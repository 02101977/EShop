var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Estas corriendo el programa Catalog-API!");

app.Run();
