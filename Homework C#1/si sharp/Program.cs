using System;
class HelloWorld {
    static void Main() {
        Console.WriteLine("Задача 2. Сравнение двух чисел");
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        if (number1 > number2)
        {
           Console.WriteLine("Большее число: " + number1 + ", меньшее число: " + number2);
        }
        else
            Console.WriteLine("Большее число: " + number2 + ", меньшее число: " + number1);
    } 
}           
         


    
