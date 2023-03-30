namespace min_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 ta son kitiring ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
           int max=Math.Max(Math.Max(a, b),(Math.Max(c,d)));
           int min=Math.Min(Math.Min(a, b),(Math.Min(c,d)));
            Console.WriteLine(max-min);
            
        }
    }
}