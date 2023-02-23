// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");

var matrix = GetMatrix(numRows, numColumns);
Print(matrix);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns)
{   int[,] matrix = new int[rows, columns];
    int number = 1;
    int maxIndex = matrix.GetLength(0) - 1;
    int tempI = 0;
    int tempJ = 0;

    while (number <= matrix.GetLength(0) * matrix.GetLength(0))
    {
        matrix[tempI, tempJ] = number;
        number++;
        if (tempI <= tempJ + 1 && tempI + tempJ < maxIndex)
            tempJ++;
        else if (tempI < tempJ && tempI + tempJ >= maxIndex)
            tempI++;
        else if (tempI >= tempJ && tempI + tempJ > maxIndex)
            tempJ--;
        else
            tempI--;
    }
    return matrix;
}

void Print(int [,] matrix)
{
    for (int tempI = 0; tempI < matrix.GetLength(0); tempI++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix [tempI,l] + " ");
        }
        Console.WriteLine();
    }
}