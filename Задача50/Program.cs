// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] numarr(int a, int b, int min, int max)
{
    int[,] array = new int[a, b];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4}, ");
            else Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
int arraynum(int[,] matrix, int indexX, int indexY)
{
    int elemValue = matrix[indexX, indexY];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexX < matrix.GetLength(0) && indexY < matrix.GetLength(1)) return elemValue;
        }
    }
    return elemValue;
}
int[,] array2D = numarr(3, 4, -100, 100);
Print(array2D);
Console.WriteLine();

if (num1 < array2D.GetLength(0) && num2 < array2D.GetLength(1))
{
    int indexnum = arraynum(array2D, num1, num2);
    Console.WriteLine(indexnum);
}
else Console.WriteLine("Введите корректные значения");