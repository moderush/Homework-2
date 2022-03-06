Console.WriteLine("Задача 15:Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ");
Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
Budni (day);
void Budni(int number)
{
    if (number > 0 && number < 6)
    {
        Console.WriteLine("Этот день является будним");
    }

    if (number > 5 && number < 8)
    {
        Console.WriteLine("Этот день является выходным");
    }

    if (number > 7)
    {
        Console.WriteLine("Такого дня не существует");
    }
}

