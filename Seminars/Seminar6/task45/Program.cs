// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

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

int[] CopyArr(int[] arr)  //метод копирования массива
{
    int[] copyarr =  new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copyarr[i] = arr[i];
    }
    return copyarr;
}

int[] array = RandomArr(10, -9, 9);
Console.WriteLine(string.Join(", ", array));
int[] copyarray = CopyArr(array);
copyarray[0] = 100;
Console.WriteLine(string.Join(", ", copyarray));