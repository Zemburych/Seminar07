// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Задайте двумерный массив размером m x n, где m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("где n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] mass = new double[m,n];
Random rand = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = rand.NextDouble() * 100;
        Console.Write($"{Math.Round(mass[i,j], 2)}" + " ");
    }
    Console.WriteLine();
}