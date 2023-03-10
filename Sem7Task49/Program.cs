//Задача №49
//Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();//очистим консоль

int ReadData(string WrDate)// пользователь вводит строки и столбцы
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void PrintData(string text, int print)
{
    Console.WriteLine($"{text}:{print}");
}

int[,] Gen2Arry(int min, int max, int RowCount, int ColCount)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[,] binarray = new int[RowCount, ColCount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
          
            binarray[i,j] = numSintezator.Next(min, max);
            if(i%2==0 && j%2==0)
            {
                binarray[i,j] *=binarray[i,j];
            }
            
        }
    }
    return binarray;
}

void Print2Arry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
       Console.WriteLine();
    }

}
int row=ReadData("Введите кол-во строк ");
int col=ReadData("Введите кол-во столбцов ");
int[,] array = Gen2Arry(20, 100, row, col);
Print2Arry(array);
