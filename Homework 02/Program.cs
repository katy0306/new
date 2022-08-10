internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт максимальное
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($" max {a}");
        }
        else
        {
            Console.WriteLine($" max {b}");
        }
    }
}