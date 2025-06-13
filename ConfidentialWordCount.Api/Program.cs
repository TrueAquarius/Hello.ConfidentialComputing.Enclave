using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;

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
    // Import the C++ function using DllImport
    [DllImport("EnclaveLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int CountWordsInEnclave(string input);

    public static int CountWords(string input)
    {
        // Call the C++ function via interop
        return CountWordsInEnclave(input);
    }
}
