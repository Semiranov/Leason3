// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int ReadNam(string mess) //метод ввода числа
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintArr(int[,] arr) //метод печати
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CountingNumbers(int[,] arr) //метод нах минимального значения
{   
   int min = arr[0,0];
   int mini = 0;
   int minj = 0;
   for(int num = 0; num < 10; num++)
   {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i,j] < min)
                {
                    min = arr[i,j];
                    mini = i;
                    minj = j;
                   // break;
                } 
            }      
        }

   }
   Console.WriteLine($"{min};{mini};{minj}");
   Console.WriteLine();
   int[,] newMatrix = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
   for(int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < newMatrix.GetLength(1); j++)
            {
                if(i != mini || j !=minj)
                {
                    newMatrix[i,j] = arr[i,j];
                }

            }      
        }
    
return newMatrix;
}

int num1 = 3; //ReadNam("Введите колличество строк: ");
int num2 = 4; //ReadNam("Введите колличество столбцов: ");
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
Console.WriteLine();
PrintArr(CountingNumbers(array));

