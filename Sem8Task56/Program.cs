//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// метод генерации двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
// метод печати двумерного массива
void Print2DArr(int[,] arr)
{
                                            
                                       
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            Console.Write(arr[i, j] + "\t");
            
        }
        Console.WriteLine();
    }
}
// метод подсчета минимального значение в строке
int MinRowCount (int[,]arr) // передаем массив
{
    int min = int.MaxValue; // присваиваем инимальному максимальное значение
    int index = -1; // изначально индекс берем -1
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      int sum = 0; // переменная для подсчета суммы элементов строки
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        sum=sum+arr[i,j]; // накапливаем результат
      }
      if (sum<min) 
      {
        min=sum;//если сумма меньше минимального значения то помещаем в минимум полученную сумму и берем индекс этого значения
        index=i; 
      }
    }
    return index;
}

int [,] testArr = Gen2DArr(3,3,1,50);
Print2DArr(testArr);
int res = MinRowCount(testArr);
Console.WriteLine("Индекс строки с наименьшей суммой: " +res);

