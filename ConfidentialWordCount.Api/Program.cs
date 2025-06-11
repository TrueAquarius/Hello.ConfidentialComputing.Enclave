using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapPost("/wordcount", async (HttpContext context) =>
{
    using var reader = new StreamReader(context.Request.Body);
    var input = await reader.ReadToEndAsync();

    // Hier wird die Enklaven-Logik aufgerufen (Platzhalter)
    // In der echten Implementierung: Übergabe an C++-Enklave via P/Invoke oder Interop
    int wordCount = EnclaveInterop.CountWords(input);

    await context.Response.WriteAsJsonAsync(new { wordCount });
});

app.Run();

public static class EnclaveInterop
{
    // Platzhalter für die echte Enklaven-Interop
    public static int CountWords(string input)
    {
        // TODO: Hier C++-Interop aufrufen
        return input.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
