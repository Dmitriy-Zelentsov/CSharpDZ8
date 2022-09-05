// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int[,,] CreateMatrix(int firstCoordinate, int secondCoordinate, int thirdCoordinate, int min, int max)
{
    var numbers = Enumerable.Range(10, 99).ToList();
    int[, ,] array = new int[firstCoordinate, secondCoordinate, thirdCoordinate];
    for (int i = 0; i < firstCoordinate; i++)
    {
        for (int j = 0; j < secondCoordinate; j++)
        {
            for (int k = 0; k < thirdCoordinate; k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return array;
}

void PrintMatrix(int[, ,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}
int [,,]array = CreateMatrix(2,2,2,10,99);
PrintMatrix(array);
