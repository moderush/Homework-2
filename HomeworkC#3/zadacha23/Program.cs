Console.WriteLine("Задача 23:Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. ");
Console.Write("Введите N от 1 до 100): ");
byte N = Convert.ToByte(Console.ReadLine());
Console.WriteLine("");

for (int i = 1; i <= N; ++i)
{
    string Text = "_________________\n";
    Text = Text + "| " + i + "\t| " + i * i * i + "\t| ";
    Console.WriteLine(Text);
}
Console.WriteLine("_________________");


