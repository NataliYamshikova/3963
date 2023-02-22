// Напишите программу которая принмает на вход число N
// и выдает таблицу кубов чисел от 1 ....N

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//string LineBulder(int num) если решаем одно действие
string LineBulder(int num,int pow) //вводим сразу переменную введения в степень pow
{ // чтобы просто число вывелось pow - 1
    string res = string.Empty; // пока оставляем результат пустой
    for (int i=1; i<=num; i++)
    {
        //res = res+i + " "; //накапливаем результат и ставим пробел если одно решение
        res= res+Math.Pow (i,pow)+"\t"; //сразу результат возводим в степень     
    }// "\t" табуляция между символами
     return res;
}
int N =ReadData("Введите число N: ");
Console.WriteLine (LineBulder(N,1));
Console.WriteLine (LineBulder (N,3)); //возводим в третью степень