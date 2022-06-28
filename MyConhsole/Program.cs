line1:
Console.WriteLine("Enter what you need:");
var job = Console.ReadLine();
if (job == "+")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("Value 1 + value 2 = " + result);
}
if (job == "-")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 - value2;
    Console.WriteLine("Value 1 - value 2 = " + result);
}
if (job == "/")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 / value2;
    Console.WriteLine("Value 1 / value 2 = " + result);
}
if (job == "*")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 * value2;
    Console.WriteLine("Value 1 * value 2 = " + result);
}
if(job == "text")
{
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
}
goto line1;