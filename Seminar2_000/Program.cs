// See https://Напишите программу которая принимает на вход два числа, и проверяет, являеться ли одно число квадратом другого
Console.WriteLine( "Введите число a" );
int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine( "Введите число b" );
int b = Convert.ToInt32(Console.ReadLine());

if ((a * a == b)^(b * b ==a ))
{
Console.WriteLine( "Да" );
}
else
Console.WriteLine( "Нет" );