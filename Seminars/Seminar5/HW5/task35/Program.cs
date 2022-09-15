// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] RandomArr(int size, int minnum, int maxnum) //метод заполнения массива рандомно
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minnum, maxnum + 1);
    }
    return arr;
}

int Koll(int[] arr)  //метод поиска чисел массива в отрезке
{
    int koll = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >=10 && arr[i] <= 99)
        {
            koll++;
        }
        
    }
    return koll;
}

int kollnum = 123;
int[] array = RandomArr(kollnum, 0, 150);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Колличество элементов массива лежащих в промежутке [10,99] = " + Koll(array));