//Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в 
//натуральную степень B.
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadData(string msg) 
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()?? "0");
} 
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

long Pow(int a, int b) //метод возведения в натуральную степерь
{
    long res =1; //переменнная для накопления результата
    while (b>0) //цикл до тех пор пока в>0
    {
        res=res*a;
        b=b-1;
    }
    return res;
}

int numA =ReadData ("Введите число A: ");
int numB =ReadData ("Введите число В: ");
long res = Pow(numA,numB);
PrintResult("Результат: " +res); 
