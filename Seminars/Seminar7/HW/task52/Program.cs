// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] RandomArr(int lines, int columns, int leftnumrand, int rightnumrund) //метод заполнения массива рандомом
{
    int[,] arr = new int[lines, columns];
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(leftnumrand, rightnumrund);
        }
    }
    return arr;
}

void PrintArr(int[,] arr) //метод печати массива
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

double SrArifm(int[,] arr)
{
    double rez = 0;
    for(int i = 0; i < arr.GetLength(1); i++)  //счетчик столбцов    
    {
        for(int j = 0; j < arr.GetLength(0); j++)  //счетчик строк
        {
            rez = rez + arr[j, i]; 
        }
        rez = Math.Round(rez / arr.GetLength(0), 1);
        Console.Write($"{rez}; ");
        rez = 0;
    }
    return rez;
}

int num1 = 3;
int num2 = 4;
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
SrArifm(array);

