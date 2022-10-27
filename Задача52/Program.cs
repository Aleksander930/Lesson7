// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}, ");
        else Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToEven)}");
    }
}

int[,] RndInt(int a, int b, int min, int max)
{
    int[,] arr = new int[a, b];
    var rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void Print(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < num.GetLength(1); j++)
        {
            if (j < num.GetLength(1) - 1) Console.Write($"{num[i, j],4}, ");
            else Console.Write($"{num[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
double[] Arrnumarey(int[,] numbers)
{
    double[] array = new double[numbers.GetLength(1)];
    int ind = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double variable = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {

            variable = (variable + numbers[i, j]);

        }
        variable = variable / numbers.GetLength(0);
        array[ind] = variable;
        ind++;
    }
    return array;
}

int[,] anumbers = RndInt(3, 4, 0, 9);
Print(anumbers);
Console.WriteLine();
double[] arrayA = Arrnumarey(anumbers);
System.Console.Write("Ответ: ");
PrintArray(arrayA);
