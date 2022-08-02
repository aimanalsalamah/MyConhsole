Line1:
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.Title = ("\f \f \f Hello, welcome to my software kingdom\f \f \f ");
Console.Beep(500, 100);

Console.WriteLine("\a Enter what you need to do");
switch (Console.ReadLine())
{
    case "+":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enter value1");
        var value1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value2 = int.Parse(Console.ReadLine());
        var result = value1 + value2;
        Console.WriteLine("value1 + value2 =" + result);
        break;
    case "-":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Enter value1");
        var value3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value4 = int.Parse(Console.ReadLine());
        var result1 = value3 - value4;
        Console.WriteLine("value3 - value4 =" + result1);
        break;

    case "*":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Enter value1");
        var value5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value6 = int.Parse(Console.ReadLine());
        var result2 = value5 - value6;
        Console.WriteLine("value5 - value6 =" + result2);
        break;

    case "/":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter value1");
        var value7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value8 = int.Parse(Console.ReadLine());
        var result3 = value7 / value8;
        Console.WriteLine("value7 /value8 =" + result3);
        break;

    case "data":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;

        foreach (var item in Tools.JsonFunctions.DeserializeJson<List<record1>>("Data"))
        {
            Console.WriteLine($" name:{item.name}\n Age:{item.Age},\n height:{item.height},\n" +
                $" weight:{item.weight},\n phone:{item.phone},\n stuidyrate:{item.studyrate},\n " +
                $"City:{item.City},\n Email:{item.Email},\n Experience:{item.Experience},\n" +
                $" Specialty:{item.Specialty},\n "); 
        }
        break;
    
    
    case "customr":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
 
        foreach (var item in Tools.JsonFunctions.DeserializeJson<List<record1>>("customr"))
        {
            Console.WriteLine($" name:{item.name}\n Age:{item.Age},"); 
        }
        break;
    case "test":
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor= ConsoleColor.Red;

        var Funtype = new Tools.FunctionTypes();
        Funtype.None();
        Funtype.Take("Fahad Almalki");
        Console.WriteLine(Funtype.Giv());
        Console.WriteLine(Funtype.TakeAndGit(50, 50));
        break;

}
goto Line1;


public class informations
{
    public record1 [] information { get; set; }
}

public class record1
{
    public string name  { get ; set; }
    public int Age { get; set; }
    public int height { get; set; }
    public int weight { get; set; }
    public string phone { get; set; }
    public string studyrate { get; set; }
    public string City { get; set; }
    public string Email { get; set; }
    public string Experience { get; set; }
    public string Specialty { get; set; }



}public class customr
{
    public string name  { get ; set; }
    public int Age { get; set; }
}
