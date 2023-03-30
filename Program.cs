namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("son kiriting ");
            int a =int.Parse (Console.ReadLine());
           for (int i = 0; i < a; i++) {
            for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{ i } * { j }= {i * j } " );
                }
            }
        }
    }
}