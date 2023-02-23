// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int random() => new Random().Next(2, 5);

var matrix = GetMatrix(random(), random());
Print(matrix);
PrintSum(matrix);

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
            matrix[i, l] = new Random().Next(1, 10);
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
void PrintSum(int[,] matrix)
{
    double sum = 0;
    double acc = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            sum += matrix[l,i];
            acc++;
        }
        System.Console.WriteLine
        ($"Среднее арифметическое чисел в столбце №{i+1}: {sum}/{acc} = {Math.Round(sum/acc,1)}");
        sum = 0;
        acc = 0;
    }
}