﻿// Задача №20
//Напишите программу, которая по заданному номер четверти
// показывает диапазон возможных координат точек в этой четверти

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintAnsuor(int num) // метод в который вводим четверть и получаем координаты
//внутри содержит условие
{
    if (num>0&&num<5)
    {
    if (num ==1 ) Console.WriteLine("x>0,y>0");
    if (num ==2 ) Console.WriteLine("x>0,y<0");
    if (num ==3 ) Console.WriteLine("x<0,y<0");
    if (num ==4 ) Console.WriteLine("x<0,y>0");
    }
    else
    Console.WriteLine("Вы ввели не верную четверть");
}
int quarter = ReadData("Введите четверть: "); //вызываем метод ReadData
PrintAnsuor(quarter);