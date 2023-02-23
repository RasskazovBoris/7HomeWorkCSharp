// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int random() => new Random().Next(1, 10);

var matrix = GetMatrix(random(), random());
Print(matrix);

int enterRows = SetNumber("строки");
int enterColumns = SetNumber("столбца");

findNumber(enterRows, enterColumns);

int SetNumber(string numberName)
{
    Console.Write($"Введите номер позиции для {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(1, 100);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void findNumber(int numOfRow, int numOfColumn)
{
    if (numOfRow > matrix.GetLength(0) || numOfColumn > matrix.GetLength(1))
    {
        System.Console.WriteLine("Такой позиции нет в данном массиве");
    }
    else
    {
        System.Console.WriteLine
        ($"В позиции {numOfRow},{numOfColumn} находится число {matrix[numOfRow, numOfColumn]}");
    }
}