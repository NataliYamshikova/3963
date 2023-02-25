//Задача №26
//Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе.

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

// разработаем метод ля подсчета цифр в числе

int DigitSum (int num)
{
    int res =0;
    while(num>0) //до тех пор пока число больше нуля
{
    res=res+1; //накапливаем результат res+=1
    num=num/10; //каждый раз убираем одно число и записываем в переменную
}   // res = num.ToString().Length; можно померить длину строки


    return res;
}

int num = RaedData ("Введите число: ");

PrintResult ("Количетсво цифр в числе:" + DigitSum (num));
// выводим на печать + сразу сичтаем результат с помощью метода