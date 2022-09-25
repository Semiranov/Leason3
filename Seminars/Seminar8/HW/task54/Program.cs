// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void MatrixSort(int[,] matr)  //сортировка матрицы от макс до мин
{
   // int max = matr[0, 0];
   for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] > matr[i, j + 1])
            {
                int temp = matr[i, j];
                matr[i, j] = matr[i, j + 1];
                matr[i, j + 1] = temp;
            } 
        }

    } 
}

int line = 3; //количество стррок
int column = 4; //количество столбцов
int[,] matrix = MatrixRandom(line, column, 0, 9);
MatrixOutput(matrix);
Console.WriteLine();
MatrixSort(matrix);
MatrixOutput(matrix);