// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int ReadData(string msg) 
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()?? "0");
} 
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int SumSimple(int num) // метод сумма
{
    int sum=0;
    while (num>0)
    {
    sum+=num%10;//sum=sum+num%10
    num=num/10;
    }
    return sum;
}

int number = ReadData ("Введите число: ");
int res = SumSimple(number);
PrintResult("Результат: " + res);