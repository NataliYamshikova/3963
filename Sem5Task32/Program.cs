// Задача №32
//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

// void PrintData(string text, int print)
// {
//     Console.WriteLine($"{text}:{print}");
// }

int[] Gen1DArry(int min, int max, int indexcount) //через массив генерируем
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[] binarray = new int[indexcount];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < indexcount; i++)
    {
        binarray[i] = numSintezator.Next(min, max);
    }
    return binarray;
}
void  Inversarray(int [] arr) //ретенр не нужент т.к. ссылочный тип данных
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*=-1; // дописать еще варианты
    }   //arr[i]=arr[i]*(-1); меняем знаки элементов на противоположные

}
void Print1Arry(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}
int[] array = Gen1DArry(-9, 9, 12);

Print1Arry(array);
Inversarray(array);
Print1Arry(array);