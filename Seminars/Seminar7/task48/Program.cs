﻿// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int ReadNumber(string message) //метод ввода чисел
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)  //метод заполнения н мерного массива
{
    int[,] matrix = new int[rowsCount, columnsCount];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //метод вывода н мерного массива
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


int m = ReadNumber("Введите колличество строк");
int n = ReadNumber("Введите колличество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
