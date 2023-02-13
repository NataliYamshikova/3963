// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write ("Введите число №1: ");
string? numLine1=Console.ReadLine(); // пишем переменную ввиде неизветной строки"?"
Console.Write ("Введите число №2: ");
string? numLine2=Console.ReadLine();// пишем переменную ввиде неизветсной строки"?"

if (numLine1 !=null&&numLine2 !=null) //наши числа не нулевые
{
    int number1=int.Parse(numLine1); //переводим строку в число
    int number2=int.Parse(numLine2); //переводим строку в число
    int max=1; // вводим переменную max 
    int min=1; // вводим переменную min
        if (number1>number2)
    {
        max = number1;
        min = number2;
    }
    else
    {
        max = number2;
        min = number1;
    }
    Console.WriteLine("Максимальное число " +max);
    Console.WriteLine("Минимальное число " +min);
}
