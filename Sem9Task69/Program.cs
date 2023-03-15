//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//

//Console.Clear();
int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
//рекурентный метод возведения в степерь числа А степень В
// long  RecPow(int a,int b)
// {

//      if (b == 1) return a ;// точка остновки
//      else return a*RecPow(a,b-1);
    
   
// }
// альтернативный метод с четными и нечетными степенями

long MyPow (int a, int b)
{
    if (b==2) return a*a;
    if (b==1) return a;

    if (b%2==0)
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a,b/2+1);
    }
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");

//long res = RecPow(a,b);
long res = MyPow(a,b);
Console.WriteLine(res);
