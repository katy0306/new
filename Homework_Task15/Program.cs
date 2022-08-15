// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7");

int day =Convert.ToInt32(Console.ReadLine());

if((day == 6) ^ (day == 7))
{
    Console.WriteLine("выходной день");
}
if((day > 0) & (day <6 ))
{
    Console.WriteLine("не выходной день");
}
