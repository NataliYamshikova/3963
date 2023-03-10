// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double[,] Gen2DArr(int countRow, int countColumn, int min, int max) //генерация двумерного массива
{
    if (min>max) // корректировка, если случайно ввели мин больше максимального
    {
        int buf = min;
        min=max;
        max=buf;
    }
    Random rnd = new Random();
    double[,] arr= new double [countRow,countColumn];

    for (int i = 0; i<countRow; i++) // цикл по строкам
    {
        for (int j = 0; j<countColumn; j++) // цикл по столбцам
        {
            arr[i,j]= rnd.Next(min, max + 1)+new Random().NextDouble(); //создание рандомных вещественных чисел
        }
    }
    return arr; // возращаем рандомный массив
}

//метод печати двумерного массива
void Print2DArray(double[,]array)
{
    
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};//массив цветов
                                        
       for(int i = 0; i<array.GetLength(0); i++) //проходим по строкам
    {
        for (int j = 0; j<array.GetLength(1); j++) // проходим по столбцам
        {
            Console.ForegroundColor = col[new Random().Next(0,16)]; // красим массив в рандомные цвета
            Console.Write(array[i,j]+ " "); // выводим массив на печать
            Console.ResetColor(); //каждый раз сбрасываем цвет
        }   
        Console.WriteLine(); 
    }
}



double[,] tesrArr = Gen2DArr(3,4,1,5);

Print2DArray(tesrArr);

