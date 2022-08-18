// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату точки x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки z2");
int z2 = int.Parse(Console.ReadLine());
double i = 0;
Console.WriteLine("Расстояние между точками");
System.Console.WriteLine(i = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)));