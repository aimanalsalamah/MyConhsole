var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();
app.UseCors(p => p.AllowAnyOrigin());
app.UseHttpsRedirection();
app.MapGet("/home", () =>
{
    return "Ok";
});
app.MapGet("/news", () =>
{
    return "Your test success";
});
app.MapGet("/Customers", () =>
{
    var customers = new List<Tools.Models.Customers>();
    for(var i = 1; i <= 100; i++)
    {
        customers.Add(new Tools.Models.Customers
        {
            name = "customer" + i,
            Age = 43 + i
        });
    }
    return customers;
});
app.MapGet("/Users", () =>
{
    var customers = new List<Tools.Models.Users>();
    for(var i = 1; i <= 100; i++)
    {
        customers.Add(new Tools.Models.Users
        {
            name = "user" + i,
            Age = 43 + i
        });
    }
    return customers;
});
app.MapGet("/Employers", () =>
{
    var customers = new List<Tools.Models.Employers>();
    for(var i = 1; i <= 100; i++)
    {
        customers.Add(new Tools.Models.Employers
        {
            name = "Employers" + i,
            Age = 43 + i
        });
    }
    return customers;
});
app.Run();