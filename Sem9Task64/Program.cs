// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от 1 до N. Выполнить с помощью рекурсии.

// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
void LineGenRec (int num) //метод генерации с помощью рекурсии
{
    if (num==1)Console.Write (num+ " ");

    else 
    {
    LineGenRec(num-1);
    Console.Write (num+ " ");
     
    }
}
int number = ReadData("Введите число: ");
LineGenRec(number);
