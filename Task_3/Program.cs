/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int rows = ReadInt("Введите количество строк: "); 
int columns = ReadInt("Введите количество столбцов: ");

int[,] arrayNumbers = new int[rows, columns];
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        arrayNumbers[i, j] = new Random().Next(0, 10);
    }
}
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        Console.Write(arrayNumbers[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");
double sum = 0;
for (int i = 0; i < arrayNumbers.GetLength(1); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(0); j++)
    {
        sum = sum + arrayNumbers[j, i];

    }
    Console.Write($"{Math.Round(sum/3,2)}; ");
    sum = 0;
}
Console.WriteLine();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}