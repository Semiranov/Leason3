// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] MatrixRandom(int line, int column, int minrand, int maxrand) //заполнение матрицы рандомом
{
    int[,] matr = new int[line, column];
    Random rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(minrand, maxrand + 1);
        }
    }
    return matr;
}

void MatrixOutput(int[,] matr) //вывод матрицы
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CompositionMatrix(int[,] matr, int[,] matr2)  //произведение матриц
{
   int[,] matr3 = new int[matr.GetLength(0), matr.GetLength(1)];
   for(int i = 0; i < matr3.GetLength(0); i++)
    {
        for(int j = 0; j < matr3.GetLength(1); j++)
        {
          matr3[i, j] = matr[i, j] * matr2[i, j];
        }

    }
    return matr3;

}

int line = 4; //количество стррок
int column = 4; //количество столбцов
int[,] matrix = MatrixRandom(line, column, 0, 9);
int[,] matrix2 = MatrixRandom(line, column, 0, 9);
MatrixOutput(matrix);
Console.WriteLine();
MatrixOutput(matrix2);
Console.WriteLine("Проезведение матриц равно:");
int[,] matrix3 = CompositionMatrix(matrix, matrix2);
MatrixOutput(matrix3);
