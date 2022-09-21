// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int Enter(string mes) //метод ввода чисел
{
    Console.WriteLine(mes);
    return Convert.ToInt32(Console.ReadLine());
}

string Find(int[,] arr, int poz1, int poz2) //метод поиска элемента
{
    string mess = String.Empty;
    if(poz1 >= 0 && poz2 >= 0)
    {
        if(poz1 <= arr.GetLength(0) && poz2 <= arr.GetLength(1))
        {
            mess = $"Значение элемента: {arr[poz1, poz2]}";
        }
        else mess = "Такого элемента нет в массиве";
    }
    else mess = "Индекс не может быть отрицательный!";
    return mess;
}

int num1 = 3;
int num2 = 4;
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
int poz1 = Enter("Введите первый индекс искомого элемента: ");
int poz2 = Enter("Введите второй индекс искомого элемента: ");
Console.WriteLine(Find(array, poz1, poz2));