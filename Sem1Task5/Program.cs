Console.WriteLine("Введите число N");
string? inputline = Console.ReadLine(); //inputline-значние которое вносит пользователь
if (inputline !=null)
{
    int inputNumber = int.Parse(inputline); //переводим в число

    string res=string.Empty;// вводим переменную для результата

    int negativNumber=inputNumber*(-1); // вводим переменную для отрицательных значений

    while (negativNumber<inputNumber) //цикл
    {
        res=res + negativNumber + "_"; //переменная была пустая, ткеперь накапливается результат, с выводом через пробел
        negativNumber=negativNumber+1; //счетчик цикла
    }

Console.WriteLine(res);
}
