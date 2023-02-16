// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrix(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        summ /= array.GetLength(0);
        Console.Write($"{summ,5} ");
    }
}

int[,] matrix = new int[4, 4];
CreateMatrix(matrix);
PrintIntArray(matrix);
Console.WriteLine("   --------------------");
ArithmeticMeanColumnArray(matrix);
