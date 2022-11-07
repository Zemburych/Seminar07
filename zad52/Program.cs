// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int m = 3;
int n = 4;
double average = 0;
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

// void average(int[,] mass);
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
         average = average + mass[i,j]; 
        } 
        Console.WriteLine($"строка {i+1} = " + average/n);
    } 
} 

