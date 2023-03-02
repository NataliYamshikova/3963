//напишите программу, которая определяет ,есть ли заданное число в массиве и вывести его индекс

int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void Print1DArray(int[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

int SearchElem(int[] arr, int elem)
{
    int result = - 1; // если элемент отсутвует то его и не покажет
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == elem)
        {
            result = i; break;
        }
    }
    return result; 
}
int[] testArr = Gen1DArray(12, -9, 9);
Print1DArray(testArr); // печатаем массив
Console.Write("Введите искомый элемент: ");
int elem = int.Parse(Console.ReadLine()??"0");//вводи элемент с терминала и преобразуем его
int searchelem = SearchElem(testArr, elem); // поиск элемента в массиве
if (searchelem>0)
{
Console.WriteLine("Искомый элемент находится в массиве с индексом: "+ searchelem);
}
else
{
    Console.WriteLine("Искомый элемент отсутствует в массиве");
}