// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число: ");
string? inputline = Console.ReadLine(); //inputline-значние которое вносит пользователь
int number = int.Parse(inputline); //переводим в число// 

    if (number %2==0) //проверка на четность
    {
    Console.WriteLine("Число четное");
    }
    else
    Console.WriteLine("Число не четное");

