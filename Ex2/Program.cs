// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindeSum(int[,] array)
{
    int[] sumarr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumarr[i] = sum;
    }
    return sumarr;
}

void PrintArraySumarr(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма эллементов {i} строки = {array[i]}\t");
    }
}

void FindMinRow(int[] sumarr)
{
    int index = 0;
    int min = sumarr[0];
    for (int i = 0; i < sumarr.GetLength(0); i++)
    {
        if (min > sumarr[i])
        {
            min = sumarr[i];
            index = i;
        }
    }
    Console.WriteLine($"Строка с индексом {index} имеет наименьшую  сумму  эллементов");
}

int[,] array = CreateMatrix(5, 3, -20, 50);
PrintMatrix(array);
Console.WriteLine();
int[] sumarr = FindeSum(array);
PrintArraySumarr(sumarr);
Console.WriteLine();
FindMinRow(sumarr);
