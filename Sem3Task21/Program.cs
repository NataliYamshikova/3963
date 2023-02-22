//  Задача №21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод находт расстояние между точками на плоскости
double CalcLen (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
} // вычисляем корень Math.Sqrt из выражения (x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)
//метод выводит данные пользователя
void PrintData(string msg,double val) // только печатает переменные
{
    Console.WriteLine(msg+val);
}
//программируем саму программу

// вызываем метод с помощью которого считаем данные от пользователя
int x1 = ReadData("Ввведите координату х точки А: ");
int y1 = ReadData("Ввведите координату y точки А: ");
int z1 = ReadData("Ввведите координату х точки A: ");
int x2 = ReadData("Ввведите координату y точки B: ");
int y2 = ReadData("Ввведите координату х точки В: ");
int z2 = ReadData("Ввведите координату y точки В: ");
// вызываем метод который нам произведет вычисления
double res = CalcLen (x1,x2,y1,y2,z1,z2);

// вызывам метод который напечатает нам данные

PrintData("Расстояние между точками А и В ",res);

// int ReadInput(string mess)
// {
//     Console.Write(mess);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }

// static double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double A = (x2 - x1) * (x2 - x1);
//     double B = (y2 - y1) * (y2 - y1);
//     double C = (z2 - z1) * (z2 - z1);
//     return Math.Sqrt(A + B + C);
// }

// static void PrintData(string mess, double val)
// {
//     Console.Write($"{mess} {val}");
// }

// int coordX1 = ReadInput("Введите кординату x точки a: ");
// int coordY1 = ReadInput("Введите кординату y точки a: ");
// int coordZ1 = ReadInput("Введите кординату z точки a: ");
// int coordX2 = ReadInput("Введите кординату x точки b: ");
// int coordY2 = ReadInput("Введите кординату y точки b: ");
// int coordZ2 = ReadInput("Введите кординату z точки b: ");


// double res = CalcLen3D(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);
// PrintData("Растояние между точками = ", res);
