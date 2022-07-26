var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();


app.MapGet("/home", () =>
{
    return "ok";
});
app.MapGet("/Yazeed", () =>
{
    var Yazeed = new List<Tools.models.yazeed>();
    for (var i = 1; i <= 100; i++)
    {
        Yazeed.Add(new Tools.models.yazeed
        {
            name = "Yazeed" + i,
            age = 29 + i
        });
    }
    return Yazeed;
});
app.MapGet("/Yaseer", () =>
{
    var Yaseer = new List<Tools.models.Yaseer>();
    for (var i = 1; i <= 100; i++)
    {
        Yaseer.Add(new Tools.models.Yaseer
        {
            name = "Yaseer" + i,
            age = 29 + i
        });
    }
    return Yaseer;
});

app.Run();
