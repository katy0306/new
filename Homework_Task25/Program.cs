// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А");
int NumbA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int NumbB = Convert.ToInt32(Console.ReadLine());

double Result = Math.Pow(NumbA, Math.Abs(NumbB));

Console.WriteLine($"Your result is: {Result}");