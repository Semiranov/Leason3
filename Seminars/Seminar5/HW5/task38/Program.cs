// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] RandomArr(int size, int minnum, int maxnum) //метод заполнения массива рандомно
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minnum, maxnum);
    }
    return arr;
}

int FindMax(int[] arr)  //метод нахождения максимального числа в массиве
{
    int max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int FindMin(int[] arr)  //метод нахождения минимального числа в массиве
{
    int min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

Console.WriteLine("Введите колличество элементов массива: ");
int koll = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArr(koll, 1, 100);
Console.WriteLine(string.Join(", ", array));
int max = FindMax(array);
int min = FindMin(array);
Console.WriteLine($"Разность максимального: {max} и  минимального: {min} чисел = {max - min}");