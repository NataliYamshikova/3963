//Ввести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника

//Считываем данные с консоли
int ReadData(string line)// пользователь вводит строки и столбцы
{
    Console.Write(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

//n!/k!*(n-k)!

long Factorial(int n)//для вычисления факториала
{
    long res=1;
    for (int i=1; i<=n;i++)
    {
        res=res*i;
    }
    return res;
}
//           1
//          1 1
//         1 2 1
void PrintPascalTriangle(int nRow) //метод печати треугольника паскаля
{
    for (int i=0; i<nRow;i++) //цикл по строкам введеным
    {
         for (int k=0 ;k<nRow-i;k++)
        {
            Console.Write(" ");
        }
       for (int j=0; j<=i;j++)
        {
         Console.Write(" ");  
         Console.Write (Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine ();
    }
}
int countRow = ReadData("Введите кол во строк треугольника Паскаля ");
PrintPascalTriangle(countRow);
Factorial(countRow);