//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

void PrintNum (int num, int m)
{
if (num < m)
{
return;
}
PrintNum(num - 1, m);
Console.Write($"{num} ");
}
Console.WriteLine("Введите число равное M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число равное N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNum(n,m);
