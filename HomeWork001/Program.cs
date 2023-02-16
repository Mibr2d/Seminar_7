// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Inputint(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

double[,] CreateArray(int row, int col, double minVal, double maxVal)
{
    Random rnd = new Random();
    double[,] myArray = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            myArray[i, j] = rnd.NextDouble() * (maxVal - minVal) + minVal;
            
        }
    }
    return myArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5:F1} ");
        }
        Console.WriteLine();
    }
}

int row = Inputint("Число строк");
int col = Inputint("Число столбцов");
int min = Inputint("Введите минимальное значение массива");
int max = Inputint("Введите максимальное значение массива");
Console.WriteLine();
double[,] matrix = CreateArray(row,col, min,max);
PrintArray(matrix);