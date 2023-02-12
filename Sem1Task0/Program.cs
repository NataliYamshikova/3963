Console.WriteLine("Введите число:");
// Считываем данные с консоли
string? inputNum = Console.ReadLine(); //наименоварие переменной inputNum-должно быть значимым
// string? - это значит, что мы не проверяем на ноль

if (inputNum != null) //проверка на ноль - что наше знание точно не пустое
{
    int number = int.Parse(inputNum); //превращает строку в число

    //int outNum = number*number;// находим крвадрат числа первый способ
    int outNum = (int)Math.Pow(number,2);//находим квадрат числа с помощью команды
    //Math.Pow(...,степень) НО! эта команда возвращает вещественные числа и нужно принудительно
    // добавить перед командой int - целые числа

    Console.Write("Квадрат числа: ");  
    Console.WriteLine(outNum); //выводим данные в консоль
    
    //Console.WriteLine("Квадрат числа: " + Math.Pow(int.Parse(inputNum),2));//решение в одну строку
}


