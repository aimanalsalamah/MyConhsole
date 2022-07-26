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
    return Users;
});
app.MapGet("/Customers", () =>
{
    var Customers = new List<Tools.Models.Customers>();
    for (var i = 1; i <= 100; i++)
    {
        Customers.Add(new Tools.Models.Customers
        {
            Name = "Customers" + i,
            Age = 25
        });
    }
    return Customers;
});
app.Run();