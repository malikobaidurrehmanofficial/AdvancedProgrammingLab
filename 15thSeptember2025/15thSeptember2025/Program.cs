namespace YourNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = calculate(5, 7);
            Console.WriteLine(res);
        }



        public static (int, int) calculate(int a, int b)
        {

            return (a + b, a - b);
        }
    }
}
