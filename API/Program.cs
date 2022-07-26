var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/home", () =>
{
    return "ok";
});
app.MapGet("/Users", () =>
{
var Users = new List<Tools.Models.Users>();
for (var i = 1; i <= 100; i++)
{
    Users.Add(new Tools.Models.Users
    {
        Name = "User" + i,
        Age = 25
    });
}
app.MapGet("/Cutomers", () =>
{
var Cutomers = new List<Tools.Models.Cutomers>();
for (var i = 1; i <= 100; i++)
{
    Cutomers.Add(new Tools.Models.Cutomers { Name = "Cutomers" + i, Age = 30 });
}
app.Run();

