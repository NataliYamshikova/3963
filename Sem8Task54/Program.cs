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
void BubbleSort(int[]array)
{
    for (int i =0;i <array.Length;i++)
      for (int j=0;j<array.Length-i-1;j++ )
     {
         if (array[j]>array[j+1])
         {
            int buf = array[j];
            array[j]=array[j+1];
            array[j+1]=buf;
         }
     }
}

void Sort2DArray(int[,]arr)
{
    int [] row = new int [arr.GetLength(1)];
    for (int i =0; i< arr.GetLength(0);i++)
    {
        for (int j=0; j<row.Length; j++)
        {
            row[j]=arr[i,j];
        }
        BubbleSort(row);
        for(int j=0; j<row.Length;j++)
        {
            arr[i,j]=row[j];
        }
    }
}

int row = ReadData("Введите количесво строк: ");
int col = ReadData("Введите количесво столбцов: ");
int [,] testArray = Gen2DArr(row,col,0,10);
Print2DArr(testArray);
Console.WriteLine();
Sort2DArray(testArray);
Print2DArr(testArray);