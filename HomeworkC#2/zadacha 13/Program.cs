Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите натуральное трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
d(num);
void d(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.WriteLine("Третья цифра числа: " + number);
    }
}








