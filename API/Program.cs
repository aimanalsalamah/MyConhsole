var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseCors(p => p.AllowAnyOrigin());

app.MapGet("/HOME", () =>
{
    return "OK";
});
app.MapGet("/Customers", () =>
{
var Customers = new List<Tools.Model.Customers>();
    for (var i = 1; i <= 140; i++)
    {
        Customers.Add(new Tools.Model.Customers
        {
            name = "Customers" + i,
            Age = 42 + i
        });
    }
    return Customers;
});

app.Run();