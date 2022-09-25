// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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

void FindMinSumm(int[,] matr)  //нахождение строки с мин суммой
{
   int summ = 0;
   int number = 0;
   int minSumm = int.MaxValue;
   for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
          summ = summ + matr[i, j];        
        }

        if(summ < minSumm)
          {
            minSumm = summ;
            number = i;
          }
          summ = 0;

    }
     Console.WriteLine($"минимальная сумма равна: {minSumm} строка: {number}"); 
}

int line = 4; //количество стррок
int column = 4; //количество столбцов
int[,] matrix = MatrixRandom(line, column, 0, 9);
MatrixOutput(matrix);
Console.WriteLine();
FindMinSumm(matrix);
