// ЗАдача № 41 Напишите задачу которая будет создавать копию одномерного массива
// с помощью поэлементного копирования


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

int[] CopyArrayStandartTools (int [] inputArr)//копирует массив метод
{
    int[] outArr=new int [inputArr.Length];//создали новый массив длинной как у старого
    inputArr.CopyTo(outArr,0); //указываем с какого элемента копируем
    return outArr;
}

int[] testArray=Gen1DArr(40,1,50);
Print1DArr (testArray);
int[] testArayNew = CopyArrayStandartTools(testArray);
Print1DArr(testArayNew);

