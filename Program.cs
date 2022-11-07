/* 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:     1 4 7 2
                            5 9 2 3
                            8 4 2 4           17 -> такого числа в массиве нет */

int[,] InitMatrix(int rows, int cols)
{
    int[,] newMatrix = new int[4, 4];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            newMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix(4, 4);
PrintMatrix(matrix);
Console.Write("Введите строку: ");
int row = int.Parse(Console.ReadLine()!);
row = row - 1;
Console.Write("Введите столбец: ");
int col = int.Parse(Console.ReadLine()!);
col = col - 1;
if(row < 0 | row > matrix.GetLength(0) | col < 0 | col > matrix.GetLength(1))
{
    Console.WriteLine("Элемент не существует.");
}
else
{
    Console.WriteLine($"Значение элемента = {matrix[row, col]} ");
}
Console.ReadLine();