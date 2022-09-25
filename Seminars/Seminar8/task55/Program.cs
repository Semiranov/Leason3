// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.


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

int[,] ReplacingStringsInColumns(int[,] arr) //метоз замены строк на столбцы
{   
    int[,] NewMatrix = new int[arr.GetLength(1), arr.GetLength(0)];
    for(int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            NewMatrix[i, j] = arr[j, i];
        }
    }
    return NewMatrix;

}

int num1 = 3; //ReadNam("Введите колличество строк: ");
int num2 = 4; //ReadNam("Введите колличество столбцов: ");
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
Console.WriteLine();
PrintArr(ReplacingStringsInColumns(array));

