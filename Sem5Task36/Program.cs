// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int [] Gen1DArray(int len, int min, int max)
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

void PrintResult(string msg)

{
    Console.WriteLine(msg);
}

int Searchposiz(int[] arr)
{
    int sum=0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i%2==1)
        {
            sum=sum+arr[i]; 
        }
    }
    return sum; 
}

int[] testArr = Gen1DArray(10,15,50);
Print1DArray (testArr);
PrintResult("Сумма элементов на нечетных позициях равна :" +Searchposiz(testArr));
