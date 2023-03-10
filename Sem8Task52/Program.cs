// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Принимаем из консоли число
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод генерации  массива случайными числами
int[,] Gen2DArrRandom(int row, int colum, int min, int max)
{            // передаем в масив строки, столбцы и заполнение от мин к макс
    Random rnd = new Random(); 
    int[,] arr = new int[row, colum];

    for (int i = 0; i < row; i++) // проходим по сторокам
    {
        for (int j = 0; j < colum; j++) // проходим по столбцам
        {
            arr[i, j] = rnd.Next(min, max); // генерируем рандомный массив
        }
    }
    return arr; //возвращаем массив рандомный
}

//Вывод двумерного массива на экран 
void Print2DArr(int[,] arr) 
{          // передаем двумерный массив
     for (int i = 0; i < arr.GetLength(0); i++) // проходим по строкам
    {
        for (int j = 0; j < arr.GetLength(1); j++) // проходим по столбцам
        {
            Console.Write(arr[i, j] + "\t"); // печатаем массив через табулятор
        }
        Console.WriteLine();
    }
}
// метод вычисления среднего арифметического в массиве по столбцам
void ArithmeticMean (int[,] arr)
{
for (int j = 0; j < arr.GetLength(1); j++) //проходим цикл по столбцам
{
    int sum = 0; // обявляем переменную суммы
    for (int i = 0; i < arr.GetLength(0); i++) // проходим по строкам
    {
        sum += arr[i, j];// считаем сумму в столбце
    }
    double res = (double)sum / arr.GetLength(0); //считаем средне арф. сумму делим на количество элементов в столбце

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {res}");//выводим результат на терминал
    Console.ResetColor();
}
}

int row= ReadData ("Введите количество строк ");
int col= ReadData ("Введите количество стобцов ");
int [,] testArr = Gen2DArrRandom(row,col,5,100);
Print2DArr(testArr);
ArithmeticMean(testArr);