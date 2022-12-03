/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Write("Введите двузначным числом позицию элемента: ");
string? number = Console.ReadLine();
Console.WriteLine();

if (number.Length != 2)
{
    Console.Write("Число не двузначное!");
    return;
}

int temp1 = Revers(0);
int temp2 = Revers(1);

int rows = 6; // Размер массива
int columns = 5;

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
Console.WriteLine();

if (temp1 <= arrayNumbers.GetLength(0) && temp2 <= arrayNumbers.GetLength(1))
{
    Console.WriteLine(arrayNumbers[temp1 - 1, temp2 - 1]);
}
else
{
    Console.Write("Такого числа в массиве нет");
}

int Revers (int i)
{
    string digit = Convert.ToString(number[i]);
    return Convert.ToInt32(digit);
}