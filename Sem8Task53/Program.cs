//Задача №53
//Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.
int ReadData(string WrDate)// пользователь вводит строки и столбцы
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    if (min>max) // корректировка, если случайно ввели мин больше максимального
    {
        int buf = min;
        min=max;
        max=buf;
    }
    Random rnd = new Random();
    int[,] arr= new int [countRow,countColumn];

    for (int i = 0; i<countRow; i++) // цикл по строкам
    {
        for (int j = 0; j<countColumn; j++) // цикл по столбцам
        {
            arr[i,j]= rnd.Next(min,max+1);
        }
    }
    return arr; // возращаем рандомный массив
}
  
// метод печати двумерного массива
void Print2DArray(int[,]array)
{
    // добавили массив цветов, для того чтобы раскрашивать симвлы
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
                                        
       for(int i = 0; i<array.GetLength(0); i++) //проходим по строкам
    {
        for (int j = 0; j<array.GetLength(1); j++) // проходим по столбцам
        {
            Console.ForegroundColor = col[new Random().Next(0,16)]; // красим массив в рандомные цвета
            Console.Write(array[i,j]+ " ");
            Console.ResetColor(); //каждый раз сбрасываем цвет
        }   
        Console.WriteLine(); 
    }
}

// метод меняет местами первую и последнюю строку
void Swap2DArray (int[,] matrix)
{                // в метод перелаем массив
    int temp =0; // замена происходит с помощью временной переменной
    for (int i=0; i<matrix.GetLength(1);i++) //идем только столбцам
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i]=temp;
    }
}

int m = ReadData("Введите колво строк ");
int n = ReadData("Введите колво столбцов ");
int[,]tesrMatrix = Gen2DArr (m,n,1,100);
Print2DArray(tesrMatrix);
Console.WriteLine();
Swap2DArray(tesrMatrix);
Print2DArray(tesrMatrix);