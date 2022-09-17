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

int[] array = RandomArr(10, -9, 9);
int[] copyarr = array;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", copyarr));
