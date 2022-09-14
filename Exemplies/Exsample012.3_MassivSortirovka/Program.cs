// Сортировка массива от мин к макс
int[] array = { 2, 1, 4, 8, 6, 3, 3, 5, 9, 6, 1 };

void PrintArray(int[] arr)  // метод вывода массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Sort(int[] arr)  // метод сортировки массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minpoz = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minpoz])
            {
                minpoz = j;
            }
        }
        int temporary = arr[i];
        arr[i] = arr[minpoz];
        arr[minpoz] = temporary;
    }
}

PrintArray(array);
Sort(array);
PrintArray(array);