line1:
Console.WriteLine("Enter what you need :");
switch (Console.ReadLine())
{
    case "data":
        var json = System.IO.File.ReadAllText(@"..\..\..\Data.json");
        var UsersData = System.Text.Json.JsonSerializer.Deserialize<List<product>>(json);
        foreach (var item in UsersData)
        {
            Console.WriteLine($"name:{item.name}, model:{item.model}, color:{item.color},type:{item.type}");
        }
        break;

    case "+":
        Console.WriteLine("Enter plusval1");
        var plusval1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter plusval2");
        var plusval2 = int.Parse(Console.ReadLine());
        var result = plusval1 + plusval2;
        Console.WriteLine("plusval1 + plusval1 = " + result);
        break;
    case "-":
        Console.WriteLine("Enter  minusval1");
        var minusval1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter  minusval2");
        var minusval2 = int.Parse(Console.ReadLine());
        var result1 = minusval1 - minusval2;
        Console.WriteLine(" minusval1 -  minusval2 = " + result1);
        break;
    case "/":
        Console.WriteLine("dividingval1");
        var dividingval1 = int.Parse(Console.ReadLine());
        Console.WriteLine("dividingval2");
        var dividingval2 = int.Parse(Console.ReadLine());
        var result2 = dividingval1 / dividingval1;
        Console.WriteLine("dividingval1 / dividingval2 = " + result2);
        break;
    case "*":
        Console.WriteLine("Enter  maxval1");
        var maxval1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter  maxval2");
        var maxval2 = int.Parse(Console.ReadLine());
        var result3 = maxval1 * maxval2;
        Console.WriteLine(" maxval1 *  maxval2 = " + result3);
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




public class product
{
    public string name { get; set; }
    public int model { get; set; }
    
    public string color { get; set; }
    public string type { get; set; }

}
