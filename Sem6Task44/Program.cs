//Задача №44
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.


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

string FibNum(int numer)//метод введения чисел фибонначи
{
    string res = "0 1 ";
    int first = 0;
    int last = 1;
    for (int i = 2; i < numer; i++)
    {
        res = res + (first + last).ToString()+ " ";
        (first, last) = (last, first+last);

    }
    return res;
}

int num = ReadInputInt("Введите число до которого выводить числа Фибоначчи: ");
WriteMess(FibNum(num));
