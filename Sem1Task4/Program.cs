// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write ("Введите число №1: ");
string? numLine1=Console.ReadLine(); // пишем переменную ввиде неизветной строки"?"
Console.Write ("Введите число №2: ");
string? numLine2=Console.ReadLine();
Console.Write ("Введите число №3: ");
string? numLine3=Console.ReadLine();
if(numLine1 != null 
   && numLine2 != null 
   && numLine3 != null )
{   
int number1=int.Parse(numLine1); //переводим строку в число
int number2=int.Parse(numLine2); 
int number3=int.Parse(numLine3); 
int max=number1; // вводим переменную max, допустим переменная равна числу №1
     if (number2>max)
    {
        max = number2;
    }
    if (number3>max);
    {
        max = number3;
    }
    Console.WriteLine("Максимальное число " +max);
}