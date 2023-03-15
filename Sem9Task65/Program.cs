// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт 
//все натуральные элементы в промежутке от M до N.
void PrintData(string msg) // только печатает переменные
{
    Console.WriteLine(msg);
}
int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
string RecMN (int m,int n) //метод генерации с помощью рекурсии
{
   string res = string.Empty;
if (m>=n)//точка остановки
{
    res=n.ToString();
}
else
{
   res = res +m + " " + RecMN(m+1,n);
}
return res;
}


int number1 = ReadData("Введите число 1: ");
int number2 = ReadData("Введите число 2: ");
string result = number1<number2?RecMN(number1,number2):RecMN(number2,number1);
// добавили защиту от дурака с помощью тернатного опрератора
PrintData(result);
