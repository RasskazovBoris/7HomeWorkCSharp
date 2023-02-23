// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.


int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");


var matrix = GetMatrix(numRows, numColumns, -100, 100);
Print(matrix);


int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = Convert.ToDouble (new Random().Next(min, max + 1))/100;
        }
    }
    return matrix;
}

void Print(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix [i,l] + " ");
        }
        Console.WriteLine();
    }
}
