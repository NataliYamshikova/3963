// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//метод генерации массива двумерного
int[,] Gen2DArray(int countRows, int countColumn, int min, int max)
{
    int[,] arr = new int[countRows, countColumn];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}
// метод печати массива двумерного
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
// метод умножения матриц,передаем два массива квадратных
int [,] DoubleArray(int [,]array1,int [,] array2)
{
int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];// создаем новую матрицу для накапливания результата

for (int i = 0; i < array1.GetLength(0); i++) //строки первого массива
{
    for (int j = 0; j < array2.GetLength(1); j++) //столбцы второго массива
    {
        for (int k = 0; k < array1.GetLength(1); k++) // цикл для нового массива
        {
            result[i, j] += array1[i, k] * array2[k, j];// чтобы умножить матрицы нам нужно строку первой умножить на столбец второй.
                                                        //Умножение строки на столбец производим по правилу скалярного произведения.
        }
    }
}
return result;
}
int [,] testArray1 = Gen2DArray(2,2,2,4); //генерируем первый массив
Print2DArr(testArray1);
Console.WriteLine();
int [,] testArray2 = Gen2DArray (2,2,2,4); // генерируем второй массив
Print2DArr(testArray2);
Console.WriteLine();
int [,] doublarr = DoubleArray(testArray1,testArray2); // умножаем массивы
Console.ForegroundColor = ConsoleColor.Green;
Print2DArr(doublarr); //выводим результат
Console.ResetColor();
