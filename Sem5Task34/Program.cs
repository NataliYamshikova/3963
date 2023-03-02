// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу,которая покажет количество чётных чисел в массиве.
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

int Searchposit(int[] arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        {
            result++;//result=result+1; 
        }
    }
    return result; 
}

void BubbleSort(int[]array)
{
    for (int i =0;i <array.Length;i++)
      for (int j=0;j<array.Length-i-1;j++ )
     {
         if (array[j]>array[j+1])
         {
            int buf = array[j];
            array[j]=array[j+1];
            array[j+1]=buf;
         }
     }
}


int[] testArr = Gen1DArray(15,100,999);
Print1DArray(testArr);

int res = Searchposit(testArr);
PrintResult ("Четных чисел в массиве: "+ res);

BubbleSort(testArr);
Print1DArray(testArr);


