// Задайте массив из 12 элементов, заполенный случайными числами в промежутке
// от [-9 до +9]. Найти сумму отрицательных и положительных элементова массива

// Вводим метод, заполняющий универсальный метод генерации массива
int[] Gen1DArr(int len, int min, int max)
{
    //Блок корректировки входных данных
    if(min>max) //проверка чтобы минимальное не было больше максимального
    {
        int buf=min;
        min=max;
        max=buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1); // генерируем случайный массив
    }
    return arr;
}

// Вводим метод, который печатает одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");// скобка массива

    for(int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");// печатаем массив через запятую
    }
    Console.Write(arr[arr.Length-1]);// печатаем последний элемент без запятой

    Console.WriteLine("]");// скобка массива
}

void PrintData(string res, int value) // чтобы распечатать результат суи=ммы
{
    Console.WriteLine(res + value);
}

//Метод который посичтает нам отрицательные и положительные суммы
(int pozitiv, int negativ) NegPosSum(int[] arr)
{
    int pozitiv = 0;
    int negativ = 0;

    for(int i=0; i<arr.Length; i++) // иде по всему массиву
    {
        if(arr[i]>0) // пока в массиве положительные значения
        {
            pozitiv += arr[i]; // накапливаем значение полож.суммы
        }
        else //иначе когда негативные
        {
            negativ += arr[i]; // накапливаем значение отрицательную суммы
        }
    }
    return (pozitiv, negativ);
}

//пишем саму программу

int[] testArr = Gen1DArr(12,-9,9); //вводим наш массив
Print1DArr(testArr);//выводим посмотреть его

(int pozit, int negat) result = NegPosSum(testArr);//вводим переменную пары значений и 
//вызываем метод подсчета
PrintData("Сумма положительных значений: ", result.pozit);// выводим рез+
PrintData("Сумма отрицательных значений: ", result.negat);// выводим рез-

//Вариант 2

// int [] NegPosSum2(int[] arr) //можно импользоваать как входной параметр массив
// {                             // тогда перед ретерн пишем дополнение
//     int pozitiv = 0;
//     int negativ = 0;

//     for(int i=0; i<arr.Length; i++) // иде по всему массиву
//     {
//         if(arr[i]>0) // пока в массиве положительные значения
//         {
//             pozitiv += arr[i]; // накапливаем значение полож.суммы
//         }
//         else //иначе когда негативные
//         {
//             negativ += arr[i]; // накапливаем значение отрицательную суммы
//         }
//     }
//     int[] outArr = new int[2];
//     outArr[0]=pozitiv;         // в первую ячейку кладет значени позитив суммы
//     outArr[1]=negativ;         // во вторую ячейку занчение негативной суссы
//     return (outArr);
// }

// int[] testArr = Gen1DArr(12,-9,9); //вводим наш массив
// Print1DArr(testArr);//выводим посмотреть его

// int [] res = NegPosSum2(testArr);//вводим переменную пары значений и 
// //вызываем метод подсчета
// PrintData("Сумма положительных значений: ", res[0]);// выводим рез+
// PrintData("Сумма отрицательных значений: ", res[1]);// выводим рез-

