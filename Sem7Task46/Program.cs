//Задача №46 Задайте двумерный массив размером m*n
//заполненный случайными числами

int ReadData(string msg) 
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()?? "0");
    
}
// метод генерации случаного двумерного массива
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
                  //строки         столбцы      заполнен числами от мин до мах
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
int row =ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] array2D = Gen2DArr(row,column,10,99);
Print2DArray(array2D);

