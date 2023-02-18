// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
string? inputnum =(Console.ReadLine()??"0");
int num = int.Parse(inputnum);

if(num>100)
{
   if (num>100&&num<1000) 
  {
   Console.WriteLine(num%10);
  }
  if (num>1000&&num<10000)
  {
  Console.WriteLine(num%100); 
  }
  if (num>10000&&num<100000)
  {
  Console.WriteLine((num/100)%10);
  }
}
else
{
Console.WriteLine("Третьей цифры нет");
}

//Вариант 2
//
//if (inputnum.Length>=3) //если длина строки больше или расна 3м символам
//{
  //char[] array = num.ToString().ToCharArray(); //обявляем массив char который числа как символы
  //Console.WriteLine(array[2]); // покажи третий символ
//}
//else //если мнеьше 3х символов то это условие
//{
//    Console.WriteLine("Третьей цифры нет");
//}


