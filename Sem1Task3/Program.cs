Console.WriteLine("Введите день недели!");
string? Lineday =Console.ReadLine();
if (Lineday!=null);
{
   int day = int.Parse(Lineday); // вводим переменную, преобразуем строку в число
   string[] dayWeek = new string [7];// вводим новую переменную dayWeek и создаем массив
   dayWeek [0]= "понедельник"; //начинаем с 0 до 6
   dayWeek [1]= "вторник";
   dayWeek [2]= "среда";
   dayWeek [3]= "четверг";
   dayWeek [4]= "пятница";
   dayWeek [5]= "суббота";
   dayWeek [6]= "воскресенье";
   Console.WriteLine(dayWeek[day-1]);// Вводим содержимое ячейки без "" иначе это текст
}

