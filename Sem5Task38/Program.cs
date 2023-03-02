//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
//Отсортируйте массив методом вставки

double [] Gen1DArray(int len, int min, int max)
{
    
    double[] arr = new double[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1)+new Random().NextDouble(); //случайные вещественные числа формирует
    }
    return arr;
}
void Print1DArray(double[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
//Сотировка методом пузырька
void BubbleSort(double[]array)
{
    for (int i =0;i <array.Length;i++)
      for (int j=0;j<array.Length-i-1;j++ )
     {
         if (array[j]>array[j+1])
         {
            double buf = array[j];
            array[j]=array[j+1];
            array[j+1]=buf;
         }
     }
}
double[] testarr =Gen1DArray(12,0,1);
Print1DArray(testarr); 
Console.WriteLine();
BubbleSort(testarr);
Print1DArray(testarr);
//выводим разницу между первым и последним элементом т.к. массив отсортирован
Console.WriteLine (testarr[testarr.Length-1]-testarr[0]);