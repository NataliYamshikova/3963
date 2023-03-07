// Создать случайный массив, перевернуть массив

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

// ВАРИАНТ1 напишим метод который переворачивает массив  через буферную переменную
void SwapArray(int[] arr)
{
    int bufElem=0; // берем для этого буферную переменную
    for (int i=0; i<arr.Length/2;i++)
    {              //берем половину массива потому что два числа сразу меняем
      bufElem=arr[i]; //первый элемент
      arr[i]=arr[arr.Length-1-i]; //последний элемент и убираем уже отсортированый i-тый элемент
      arr[arr.Length-1-i]=bufElem;                               
    }             

}
//ВАРИАНТ2 напишим метод который переворачивает массив сосздав новый массив

int[] SwapNewArr(int[]arr)
{
    int[] outArr=new int[arr.Length]; //объявляем новый массив,который будет перевернутый
    //используем для этого цикл
    for (int i=0;i<outArr.Length;i++)
    {    
      outArr[i]=arr[arr.Length-1-i];//берем последний элемент старого массива и помещаем в новый     
    } // так мы пройдем по всему массиву старому и поместим в новый развернув
    return outArr; //возвращаем новый массив
}


int [] testArray = Gen1DArr(20,10,100); //генерация случайного массива
Print1DArr(testArray);// вывод случайного массива
Console.WriteLine();
//SwapArray(testArray); //переварачиваем массив
int[] newArray= SwapNewArr(testArray); // переворачиваем вторым методом
Print1DArr(newArray);//снова выводим на перчать чтобы видеть что получилось