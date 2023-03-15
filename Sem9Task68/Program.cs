// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string WrDate)// пользователь вводит 
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
// метод рассчета функции Аккермана
int Ackermann(int m, int n)
{
        if (m == 0) 
        { 
            return n + 1;
        } 
        else if (n == 0) 
        { 
            return Ackermann(m - 1, 1);
        } 
        else 
        {
            return Ackermann(m - 1, Ackermann(m, n - 1)); // рекурсивный вызов
        }
}

int m = ReadData ("Введите число m: ");
int n = ReadData ("Введите число n: ");
Console.WriteLine("А(m,n)= "+ Ackermann(m,n));
