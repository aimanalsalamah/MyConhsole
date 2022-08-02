namespace Tools
{
    public class FunctionTypes
    {
        public void None()
        {
            Console.WriteLine("You call me!");

        }
        public void Take(string YourName)
        {
            Console.WriteLine($"Hi {YourName}");
        }
        public int Giv()
        {
            return 777;
        }
        public int TakeAndGit(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
