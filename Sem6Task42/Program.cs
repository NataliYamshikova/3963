//Задача №42
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.


//Принимаем из консоли число
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

int num = ReadInputInt("Введите число: ");

string DecToBin(int numer) //метод преобразования числа в двоичное
{
    string result = ""; //возвращает строку
    while (numer > 0) //пока число делится
    {
       result =numer % 2 + result; //остаток от деления на 2 за писываем в результат
       numer /= 2;//делим число на 2
    }
    return result;
}
// есть встроенный метод перевода в 2,8,16 ричные системы
// string DecToBinNativ(int num)
  // {
   // return Convert.ToString(num,2);
  // }    
WriteMess($"Число {num} в двоичной системе = {DecToBin(num)}");
