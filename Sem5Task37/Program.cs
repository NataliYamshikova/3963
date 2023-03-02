// Задача №37 Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.


int[] Gen1DArr(int len, int min, int max)
{
        if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] ConvertArr(int[] arr) 
{
    int len = arr.Length/2;
    if(arr.Length%2==1)
    {
        len=len+1;
    }

    int[] bufarr = new int[len];
    
    for (int i = 0; i < len; i++)
    {
        bufarr[i] = arr[i] * arr[len-1];
    }

    return bufarr;
}

int[] testarr = Gen1DArr(11, -100, 100);
Print1DArr(testarr);

Print1DArr(ConvertArr(testarr));