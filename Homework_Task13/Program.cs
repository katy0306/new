//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число");
string numberString =Console.ReadLine();

int number =Convert.ToInt32(numberString);

if ((number < -99) ^ (number > 99))
{
    char third =numberString[2];
    Console.WriteLine(third);

}
else
{
    Console.WriteLine("Третей цифры нет");
}
