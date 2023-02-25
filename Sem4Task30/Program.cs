//Сгенерируйте одномерный массив состоящий из 0 и 1 и 8 символов

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
PrintArray(GenArray(10,0,1));

