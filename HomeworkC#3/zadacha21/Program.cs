
Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Укажите значение первой точки: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите значение второй точки: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите значение третьей точки: ");
int num3 = int.Parse(Console.ReadLine());

d3(num1);
d3(num2);
d3(num3);
void d3(int number)
{
    Random rand = new Random();
    int AX = rand.Next(1, 10);
    int AY = rand.Next(1, 10);
    int BX = rand.Next(1, 10);
    int BY = rand.Next(1, 10);
    int ZX = rand.Next(1, 10);
    int ZY = rand.Next(1, 10);
    Console.WriteLine("Точка А - " + AX + ":" + AY);
    Console.WriteLine("Точка B - " + BX + ":" + BY);
    Console.WriteLine("Точка Z - " + ZX + ":" + ZY);
    double rasst = Math.Sqrt((AX - BX) * (AX - BX) + (AY - BY) * (AY - BY) + (ZX - ZY) * (ZX - ZY));
    Console.WriteLine("Длина отрезка : " + rasst);

}

