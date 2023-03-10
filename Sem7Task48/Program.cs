//Задача №48
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n.(строка +столбе знач)
//Выведите полученный массив на экран.

// Модифицированный метод создания 2д массива
int[,] Gen2DArrayMod(int countRows, int countColumn)
{
    int[,] arr = new int[countRows, countColumn];
    
        for (int i = 0; i < countRows; i++) // цикл строк
        {
            for (int j = 0; j < countColumn; j++) //цикл столбцов
            {
                arr[i, j] = i + j; //заполнение массива индекс строки + индекс столбец
            }
        }
    
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] testArr = Gen2DArrayMod(8, 9);
Print2DArr(testArr);
