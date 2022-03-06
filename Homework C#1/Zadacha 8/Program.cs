Console.WriteLine("Задача 8. Четные числа от 1 до N.");
Console.WriteLine("Введите число: ");
Console.WriteLine("_______________");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (counter <=N)
{
if (counter % 2 == 0)
{
 Console.Write (counter+ " ");
}
counter++;
}

