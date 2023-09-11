internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("輸入一個整數n");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"{i}*{j}={i * j}");
            }
            Console.WriteLine();
        }
    }
}