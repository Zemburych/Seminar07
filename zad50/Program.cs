// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
int m = 5;
int n = 3;

int[,] mass = new int[m,n];
Random rand = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = rand.Next(1,9);
        Console.Write($"{mass[i,j]}" + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите координаты элемента (начиная с 0)");
Console.Write("Строка -> ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Столбец -> ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m || b>n)
 Console.WriteLine("такого числа в массиве нет");
 else 
 Console.WriteLine($"искомый элемент -> " + mass[a,b]);

