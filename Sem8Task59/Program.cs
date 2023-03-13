//Задача №59
//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
int ReadData(string WrDate)// пользователь вводит строки и столбцы
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
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
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "  ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int [,] Update2DArr (int[,]arr, int row, int col)
{
    int [,] resalt = new int [arr.GetLength(0)-1,arr.GetLength(1)-1];
    int k = 0; // вводим индекс строки нового массива
    int m = 0; // вводим индекс столбца нового массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j !=col&& i!=row)
            {
             resalt [k,m] = arr [i,j];
            }
            if(j !=col) m++;
        }
        if(i !=row) k++;
    }
    return resalt;
}

//метод поиска минимального значения в массиве
(int x, int y) SearchMinElem2DArr (int[,] matrix)
//метод выдаст индекс строка x столбец y, примет двумерный массив
{
    int row=0; //строка мин элемента
    int col =0; // столбец мин элемента
    int min = int.MaxValue;//сам мин элемент присваиваем значение максимального
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]<min) // если значение массива меньше минимального
            {
                min=matrix[i,j]; // мин присвоим это значение
                row=i; // строке значение i
                col=j; // столбцу значение j
            }
        }
    }
    return(row,col); // возвращаем значние индекса элемента строку и столбец

}

int row = ReadData("Введите количесвтво строк ");
int col = ReadData("Введите количесвтво столбцов ");
int[,] arr2D =Gen2DArr(row,col,0,99);
Print2DArr(arr2D);
Console.WriteLine();
(int x,int y) minElem = SearchMinElem2DArr(arr2D);
int[,] out2DArr = Update2DArr(arr2D,minElem.x,minElem.y);
Print2DArr(out2DArr);