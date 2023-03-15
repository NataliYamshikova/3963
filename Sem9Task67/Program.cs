//Задача 67
// примает на вход число и возвращает сумму цифр числа
// 


int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int RecSumDig (int num) //сумма чисел с помощью рекурсии
{
if (num==0) return 0; // точка остановки
else return num%10+RecSumDig(num/10); //убираем каждый раз одно число и складываем их
}

int number = ReadData("Введите число: ");
int res = RecSumDig(number);
Console.WriteLine (res);