// Задача №24
//Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
//
int RaedData(string line) 
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP=int.Parse(Console.ReadLine()?? "0");
    return numberP; //возвращаем значение
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumSimple(int numA) // метод простая сумма
{
    int sum=0;
    for (int i=1; i<=numA;i++)
    {
    sum+=i;//sum=sum+i
    }
    return sum;
}
int SumGausse(int numA) // метод суммы Гауса
{
    
    return ((1+numA)*numA)/2;
}

//Пишем саму программу с помощью методов

int numberA = RaedData("Введите число А: ");

DateTime d1 = DateTime.Now; // мерием время
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1); //выводим время

DateTime d2 = DateTime.Now;
int res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult ("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintResult ("Сумма чисел от 1 до А равна (метод Гаусса): " + res2);