// Задача №28
//Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N. (поиск факториала)

int ReadData(string msg) 
{
    //выводим сообщение
    Console.Write(msg);
    //считываем число
    int numberP=int.Parse(Console.ReadLine()?? "0");
    return numberP; //возвращаем значение
}



long FactorMetod (int num)
{
long sum = 1;
for(int i=2; i<=num; i++)
{
sum=sum*i;
}
return sum;
}

int num = ReadData("Введите число N: ");
long res = FactorMetod (num);//очень большие числа не осилит
Console.WriteLine("Результат равен: " + res);