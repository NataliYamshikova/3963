// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//метод сложения элементов с помощью рекурсии

int RecSumMN (int m,int n) 
{  if (m == n) return m; //точка остановки
   else return m + RecSumMN(m + 1, n); // рекурсивный вызов     
}


int number1 = ReadData("Введите число М: ");
int number2 = ReadData("Введите число N: ");
int result = number1<number2?RecSumMN(number1,number2):RecSumMN(number2,number1);// добавили защиту от дурака с помощью тернарного опрератора

Console.WriteLine("Сумма элементов равна: "+ result);
