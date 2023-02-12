Console.WriteLine("Введите число N");
string? inputline = Console.ReadLine(); //inputline-значние которое вносит пользователь
if (inputline !=null)
{
    int number = int.Parse(inputline); //переводим в число// 
    if (number>99 && number<1000) //проверка на то что число трехзначное
    {
    int res=number % 10; //остаток от деления на 10
    Console.WriteLine("Последняя цифра числа "+ res);
    }
    else
    Console.WriteLine("Введено неверное число");
}