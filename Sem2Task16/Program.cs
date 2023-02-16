//Напишите программу, которая принимает на вход два числа
//и проверяет,  является ли одно число квадратом другого.
Console.Write("Введите число№1: ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число№2: ");
int numB = int.Parse(Console.ReadLine()??"0");

void SquareTest(int num1, int num2)
{
    if(num1==num2*num2) // Math.Pow(secondNum,2)
    {
        Console.WriteLine($"Число {num1} является квадратом {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом {num2}");
    }
}
SquareTest(numA,numB);

SquareTest(numB,numA);