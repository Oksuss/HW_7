//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
 int [] array = {5, 10, 15, 20, 25, 30, 35};
 Print_array(array);
Console.WriteLine();
void Print_array(int[] array)
{
    foreach (var i in array)
    {
        Console.Write($"{i} ");
    }
}
void FlipElements(int[] array, int n)
{
    if (n > 0)
    {
        Console.Write(array[n] + " ");
        FlipElements(array, n - 1);
    }
    else Console.WriteLine(array[0]);
}
{
    int[] flip = array;
    FlipElements(flip, flip.Length - 1);
}

