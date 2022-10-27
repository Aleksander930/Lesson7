// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array(int num, int nums)
{
    double[,] arr = new double[num, nums];
    var a = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(a.NextDouble() * 10, 1);
        }
    }
    return arr;
}
void PrintMatrix(double[,] arraynums)
{
    for (int i = 0; i < arraynums.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arraynums.GetLength(1); j++)
        {
            if (j < arraynums.GetLength(1) - 1) Console.Write($"{arraynums[i, j],4}, ");
            else Console.Write($"{arraynums[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
double[,] arraya = array(3, 4);
PrintMatrix(arraya);