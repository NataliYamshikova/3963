// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//Метод генерации трехмерного массива

int[,,] Gen3DArr(int x, int y, int z, int min, int max) // метод получает 3 параметра массива и заполнение мин и мах значением
{

int[,,] array = new int [x, y, z]; 

Random random = new Random();
/// для генерации 3х мерного массива используем 3 цикла, идем по трем параметрам
for (int i = 0; i <array.GetLength(0) ; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = random.Next(min,max+1);
        }
    }
}
return array;
}
// метод печати трехмерного массива
void Print3DArr(int[,,] arr) // передаем трехмерны массив
{
                                    
                                      
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
           Console.Write(arr[i, j, k] +" " + (i,j,k)); // печатаем массив + индексы
        }
        Console.WriteLine();
    }
    
    }
}
int [,,] test3DArr = Gen3DArr(2,2,2,10,99);
Print3DArr(test3DArr);