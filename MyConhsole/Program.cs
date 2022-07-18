// this is mohammeds branch
line1:
Console.WriteLine("Enter what you need to do:");

switch (Console.ReadLine())
{
    case "data":
        foreach (var item in Tools.JsonFunctions.DeserializeJson<List<users>>("Data"))
        {
            Console.WriteLine($"name:{item.name}, Age:{item.age}, Mobile:{item.mobile}");
        }
        break;
    case "customer":
        foreach (var item in Tools.JsonFunctions.DeserializeJson<List<Customers>>("Customers"))
        {
            Console.WriteLine($"name:{item.name}, Age:{item.age}");
        }
            break;
    case "-":
        Console.WriteLine("Enter value1");
        var value3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value4 = int.Parse(Console.ReadLine());
        var result1 = value3 - value4;
        Console.WriteLine("Value 1 - value 2 = " + result1);
        break;
    case "/":
        Console.WriteLine("Enter value1");
        var value5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value6 = int.Parse(Console.ReadLine());
        var result2 = value5 / value6;
        Console.WriteLine("Value1 / value2 = " + result2);
        break;
    case "*":
        Console.WriteLine("Enter value1");
        var value7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value8 = int.Parse(Console.ReadLine());
        var result3 = value7 * value8;
        Console.WriteLine("Value 1 * value 2 = " + result3);
        break;
    case "text":
        Console.WriteLine("Do you want to read or write");
        var selection = Console.ReadLine();
        if (selection == "read")
        {
            var noteText = System.IO.File.ReadAllText("Note.txt");
            Console.WriteLine(noteText);
        }
        if (selection == "write")
        {
            Console.WriteLine("Please enter your note");
            var entry = Console.ReadLine();
            System.IO.File.AppendAllText("Note.txt", entry + "\n");
        }
        break;
    default:
        Console.WriteLine("Wrong command.");
        break;
}
goto line1;

public class users
{
    public string name { get; set; }
    public string mobile { get; set; }
    public int age { get; set; }
}

public class Customers
{
    public string name { get; set; }
    public int age { get; set; }
}

