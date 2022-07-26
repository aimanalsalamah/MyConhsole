var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/Home", () =>
{
    return "ok";
});



app.MapGet("/User", () =>
{
    var User = new List<Tools.Model.User>();
    for(var i = 1; i <= 100; i++)
    {
        User.Add(new Tools.Model.User
        {
            name = "User" + i,
            Age = 23 + i
        });
    }
    return User;
});


app.MapGet("/Customer", () =>
{
    var Customer = new List<Tools.Model.Customer>();
    for (var i = 1; i <= 100; i++)
    {
        Customer.Add(new Tools.Model.Customer
        {
            name = "Costomer" + i,
            Age = 22 + i
        });
    }
    return Customer;
});

app.Run();

