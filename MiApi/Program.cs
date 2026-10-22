using MiApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var calculadora = new Calculadora();

app.MapGet("/", () => "Hola, la API de la calculadora está funcionando.");

app.MapGet("/sumar", (int a, int b) => calculadora.Sumar(a, b));
app.MapGet("/restar", (int a, int b) => calculadora.Restar(a, b));
app.MapGet("/multiplicar", (int a, int b) => calculadora.Multiplicar(a, b));

app.MapGet("/dividir", (int a, int b) =>
{
    if (b == 0)
        return Results.BadRequest("No se puede dividir por cero.");

    return Results.Ok(calculadora.Dividir(a, b));
});

app.Run();
