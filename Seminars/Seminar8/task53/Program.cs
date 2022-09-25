// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

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

void ReplacingStrings(int[,] arr) //метоз замены строк
{   
    int num1 = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        num1 = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0)-1, j];
        arr[arr.GetLength(0)-1, j] = num1;

    }
}

int num1 = 3; //ReadNam("Введите колличество строк: ");
int num2 = 4; //ReadNam("Введите колличество столбцов: ");
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
Console.WriteLine();
ReplacingStrings(array);
PrintArr(array);

