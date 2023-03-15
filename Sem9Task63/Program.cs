//Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
void LineGenRec (int num) //метод генерации с помощью рекурсии
{
    Console.Write (num+ " ");
if (num==1)//точка остановки
{
}
else
{
  LineGenRec(num-1);//изменения при слудующем вызове
}
}
int number = ReadData("Введите число: ");
LineGenRec(number);