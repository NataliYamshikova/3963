//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int ReadData(string msg) // вводим данные с терминала
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
            arr[i,j]= rnd.Next(min,max+1); //собираем рандомный массив
        }
    }
    return arr; // возращаем рандомный массив
}

// метод печати двумерного массива
void Print2DArray(int[,]array)
{
    // добавили массив цветов, для того чтобы раскрашивать символы
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
            Console.Write(array[i,j]+ " "); // выводим цветной масив
            Console.ResetColor(); //каждый раз сбрасываем цвет
        }   
        Console.WriteLine(); 
    }
}

void Print2DArrElem(int[,] arr, int num) // метод поиска элемента в двумерном массиве
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num) // если элемент совпал
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // окрашиваем его в желтый цвет (можно в любой)
                Console.Write(arr[i, j]+" "); // выводим на печать
                Console.ResetColor();// сбрасываем цвет
            }
            else
            {
                Console.Write(arr[i, j]+" "); // если элемента нет то массив выводим одного цвета
            }
        }
        Console.WriteLine();
    }

}

int[,] testarr = Gen2DArr (3,5,10,99); 
Print2DArray(testarr);
int element = ReadData ("Введите число ");
Print2DArrElem(testarr, element);