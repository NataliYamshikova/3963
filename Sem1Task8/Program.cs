//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
string? inputline = Console.ReadLine(); //inputline-значние которое вносит пользователь
if (inputline !=null)
{
    int number = int.Parse(inputline); //переводим в число// 
    string res=string.Empty;// вводим пустую переменную для результата
    int index=1;

    while (index <= number) //цикл
    {
    if(index%2==0)//проверка на то что число четное
    res=res+index +" "; //накпливаем результат
    index=index+1;  
    }
    Console.WriteLine("Четные числа " +res);
}
