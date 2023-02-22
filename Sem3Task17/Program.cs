//Задача №17
//Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится 
//эта точка.
//<тип> <имя метода> (тип название переменной)
//{
//    return <тип>
//}

int ReadData(string msg)// метод считывания данных пользователя
{
    Console.WriteLine(msg);// выводим данные для пользователя
    return int.Parse(Console.ReadLine()??"0");//возврат данных
}


void PrintQuterTest(int x, int y) // метод который определит в какой четверти лежит координата
{
    if (x> 0 && y> 0) Console.WriteLine("Точка в 1 четверти");
    if (x> 0 && y< 0) Console.WriteLine("Точка в 2 четверти");
    if (x< 0 && y< 0) Console.WriteLine("Точка в 3 четверти");
    if (x< 0 && y> 0) Console.WriteLine("Точка в 4 четверти");

}
int coordX = ReadData("Введите координату Х: "); //вызываем метод ReadData
int coordY = ReadData("Введите координату Y: "); //вызываем метод ReadData

PrintQuterTest(coordX,coordY);