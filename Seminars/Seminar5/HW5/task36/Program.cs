// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Sum(int[] arr)  //метод суммы на нечетных позициях
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Console.WriteLine("Введите колличество элементов массива: ");
int koll = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArr(koll, -9, 9);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + Sum(array));
