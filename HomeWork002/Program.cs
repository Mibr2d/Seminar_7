// Задача 2: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4


bool SearchNumberInArray(int[,] array, int findNumber)
{

    bool isFound = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNumber)
            {
                Console.Write((isFound ? "" : "Найдено:\n"));
                Console.WriteLine($"[{i},{j}]");
                isFound = true;
            }
        }
    }
    return isFound;
}


int[,] CreateMatrix()
{
    int[,] matrix = new int[3, 4];



    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

int Inputint(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[,] myTestArray = CreateMatrix();

int findNum = Inputint("Введите число для поиска");
bool resultSearch = SearchNumberInArray(myTestArray, findNum);
if (!resultSearch)
{
    Console.WriteLine($"Элемент со значением {findNum} не найдены");
}
