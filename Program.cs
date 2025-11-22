using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("play", async (HttpContext context) =>
    {
        Random random = new Random();
        double number = Math.Round(random.NextDouble()*6);
        await context.Response.WriteAsync(number.ToString());
    });
});

app.Run();
