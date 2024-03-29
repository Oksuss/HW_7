//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int FunctionAckermans(int m, int n)
{
    if(m == 0) return n+1;
    else if (m > 0 && n == 0) return FunctionAckermans(m - 1, 1);
    else return FunctionAckermans(m - 1, FunctionAckermans(m, n - 1));
}
Console.Write("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{FunctionAckermans(m,n)}");
