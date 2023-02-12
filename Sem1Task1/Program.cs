Console.Write ("Введите число №1: ");
string? numLine1=Console.ReadLine(); // пишем переменную вв иде неизветной строки"?"
Console.Write ("Введите число №2: ");
string? numLine2=Console.ReadLine();// пишем переменную в виде неизветсной строки"?"

if (numLine1 !=null&&numLine2 !=null) //наши числа не нулевые, &&-логическое "и", выполняется право и лево
{
int num1 = int.Parse(numLine1);//перводим строку в число
int num2 = int.Parse(numLine2);//переводим строку в число

//if(num1==(int)Math.Pow(num2,2)) альтернативное решения с функцией

if (num2*num2==num1) //проверяем условие задачи, квадрат второго числа есть первое число?
{
  Console.WriteLine("Является!"); //если да то ответ
}
else 
{
    Console.WriteLine("Не является!"); // иначе такой ответ
}
}

//Альтернативное решение 
//Console.Write("Введите число №1 ");
//var number1 =Convert.ToDouble(Console.ReadLine()); !!!ToInt32 вместо ТоDouble
//Console.Write("Введите число №2 ");
//var number2 =Convert.ToDouble(Console.ReadLine()); !!!ToInt32 вместо ТоDouble

//if (number1==Math.Pow(number2,2) ) !!!тогда тут перед (int)Math.Pow
   //Console.WriteLine($"Число {number1} является квадратом числа {number2}");
//else
   //Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");
