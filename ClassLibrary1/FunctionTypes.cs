namespace Tools
{
    public class FunctionTypes
    {
        public void None()
        {
            Console.WriteLine("You call me!");
        }

        public void Take(string YourNhame)
        {
            Console.WriteLine($"Hi {YourNhame}");
        }

        public int Giv()
        {
            return 666;
        }

        public int TakeAndGit(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}