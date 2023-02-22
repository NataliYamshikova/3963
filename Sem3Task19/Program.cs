// Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно 
//палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

bool PolinTest (int num) //проверка числа на поллиндром метод правда или ложь
{
   bool res = false;
 if ((num/10000==num%10)&&((num/1000)%10==(num/10)%10))
     //первое и пятое        второе      и четвертая
     {
    res = true;
}
return res;
}

int NumInput = ReadData ("Введите число"); 
bool resultTest = PolinTest(NumInput);//вводим переменную с bool и 
//кладем в нее значение из нашего метода, там сразу проходит проверка на правде или ложь

if (resultTest) //если переменная прошла тест то ответ да
{
Console.WriteLine ("да");
}
else  
{
Console.WriteLine ("нет");
}
