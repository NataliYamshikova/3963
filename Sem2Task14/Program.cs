Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
bool oper = (num%23==0)&&(num%7==0);
if (oper)
{
Console.WriteLine ("кратно 23 и 7");
}
else
{
Console.WriteLine (" не кратно 23 и 7");
}