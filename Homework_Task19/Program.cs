// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");

    int a = int.Parse(Console.ReadLine());

    if ((a < 100000) & (a > 9999))
    {
        if((a / 10000) == (a % 10) && ((a / 1000) % 10) == ((a / 10) % 10))
        {
             System.Console.WriteLine("Палиндром");   
        }

    else
    {
        System.Console.WriteLine("Не палиндром");
    }    
    }
    if ((a > 99999) ^ (a < 1000))
    {
        System.Console.WriteLine("Не пятизначное число");
    }
