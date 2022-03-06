Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

palindrom(num);
void palindrom(int number)
{
    while (number < 10000 || number > 99999)
    {
        Console.WriteLine("Укажите пятизначное число");
        number = int.Parse(Console.ReadLine());
    }
    int digital1 = number / 10000;
    int digital2 = number / 1000 % 10;
    int digital4 = number / 10 % 10;
    int digital5 = number % 10;
    if (digital1 == digital5 && digital2 == digital4)
        Console.WriteLine("Заданное число является палиндромом");
    else
    {
        Console.WriteLine("Заданное число не является палиндромом");
    }


}
