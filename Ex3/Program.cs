// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrix(int iCount, int jCount, int min, int max)
{
    int[,] array = new int[iCount, jCount];
    for (int i = 0; i < iCount; i++)
    {
        for (int j = 0; j < jCount; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrix(5, 3, 1, 2);
Console.WriteLine("Вывод первой матрицы");
PrintMatrix(array);
Console.WriteLine();
int[,] arr = CreateMatrix(3, 5, 1, 2);
Console.WriteLine("Вывод второй матрицы");
PrintMatrix(arr);
Console.WriteLine();

int[,] ArrayMultiplication(int[,] array, int[,] arr)
{
    int[,] arrayMultiplication = new int[array.GetLength(0), arr.GetLength(1)];
    if (array.GetLength(1) == arr.GetLength(0))
    {
        for (int i = 0; i < arrayMultiplication.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMultiplication.GetLength(1); j++)
            {
                arrayMultiplication[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    arrayMultiplication[i, j] += array[i, k] * arr[k, j];
                }
            }
        }
    }
    else
    Console.WriteLine("Умножать матрицы друг на друга можно, когда число столбцов первой равно числу строк второй");
    return arrayMultiplication;
}

int[,] arrmulti = ArrayMultiplication(array, arr);
Console.WriteLine("Вывод результирующей матрицы");
PrintMatrix(arrmulti);






