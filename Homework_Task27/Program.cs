// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите любое число");
try
{
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    while(number != 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
        Console.WriteLine(number);  
        Console.WriteLine(sum);
    }
}
finally
{
Console.WriteLine("сумма цифр");
}