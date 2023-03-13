// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

//научилась прользоваться чатом GPT
//метод генерации масива спиралью
int [,] SpiralGen2DArray (int row, int col, int min, int max) 
{
int[,] array = new int[row,col]; // инициируем массив чтобы пометить результат

int value = 1; // объявляем переменную 
int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3; // объявляем переменные для того чтобы идти по нужным строка и столбцам и в нужном направлении

while (rowStart <= rowEnd && colStart <= colEnd) 
{
    for (int i = colStart; i <= colEnd; i++)// Заполнение верхней строки
    {
        array[rowStart, i] = value++;
    }
    rowStart++; // двигаемся вперед
    
    for (int i = rowStart; i <= rowEnd; i++)// Заполнение правого столбца
    {
        array[i, colEnd] = value++;
    }
    colEnd--; // двигаемся назад

    
    if (rowStart <= rowEnd)// Заполнение нижней строки
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = value++;
        }
        rowEnd--; // двигаемся назад
    }

    
    if (colStart <= colEnd)// Заполнение левого столбца
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = value++;
        }
        colStart++; // двигаемся вперед
    }
}
return array;
}

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

int [,] Spiral2DArr= SpiralGen2DArray(4,4,0,16);
Print2DArr (Spiral2DArr);