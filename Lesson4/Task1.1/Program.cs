﻿int [,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)//4-11 заполнение массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}


void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)//13-20 вывод массива на экран
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);