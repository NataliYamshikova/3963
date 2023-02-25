// Задача 29: Напишите программу, которая задаёт массив 
//из N элементов и выводит их на экран. 
//Ввести с клавиатуры длину массива и диапазон значений элементов.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int ReadData(string msg) 
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()?? "0");
    
}
// Метод генерации одномерного массива
int[] GenArray (int len, int min, int max)
{
    int[] array= new int[len];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(min,max+1);
    }   //генерируем массив из случайних чисел от мин до мах 
    return array;
}
void PrintArray(int[] arr) //метод печати
{
    Console.Write ("["); //скобка слева
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write($"{arr[i]},"); //выводим массив через запятую
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
}    // выводим последний элемент массива и правую скобку


int len = ReadData("Введите длину массива: ");
int max = ReadData("Введитеи макс значение массива: ");
int min = ReadData("Введитеи мин значение массива: ");
int[] array = GenArray (len,min,max);
PrintArray (array);

