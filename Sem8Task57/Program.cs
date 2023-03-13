﻿//Задача №57
//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.

int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length - 1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

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
// метод заполнения частотного словаря, возвращает одномерный массив
int[] BuildFreqDic(int[,] arr, int length) // передаем массив двемерный и алфавит
{
    int[] dictionary = new int[length];// одномерный массив длиной заданной алфавитом
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            dictionary[arr[i,j]]++; //заполнения словаря суммирование индексов повторяющися элементов
        }
    }
    return dictionary;
}

int inRow = ReadData("Please enter the desired number of rows: ");
int inCol = ReadData("Please enter the desired number of columns: ");
int[,] testArr = Gen2DArray(inRow, inCol, 0, 9);
Print2DArr(testArr);
Console.WriteLine();

int[] freqDic = BuildFreqDic(testArr, 10);
Print1DArray(freqDic);