// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] RandomArr(int lines, int columns) //метод заполнения массива рандомом
{
   // rightnumrund = rightnumrund * 2;
    double[,] arr = new double[lines, columns];
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {                                   
            arr[i, j] = Math.Round(rand.NextDouble() * 20 -  10, 1);
        }
    }
    return arr;
}

void PrintArr(double[,] arr) //метод печати массива
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int num1 = 3;
int num2 = 4;
double[,] array = RandomArr(num1, num2);
PrintArr(array);


