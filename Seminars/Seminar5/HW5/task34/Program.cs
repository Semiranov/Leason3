// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int Koll(int[] arr)  //метод поиска четных чисел в массиве
{
    int koll = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            koll = koll + 1;
        }
    }
    return koll;
} 

Console.WriteLine("Введите колличество элементов массива: ");
int kollnum = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArr(kollnum, 100, 999);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Колличество четных чисел в массиве = " + Koll(array));