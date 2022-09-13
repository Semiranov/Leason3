// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GettArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
// true есть эллемент false нет
bool IsNumberInArray(int[] array, int findNumber)
{
    bool isNumberInArray = false;
    for(int i = 0;i < array.Length; i++ )
    {
        if(array[i] == findNumber)
        {
            isNumberInArray = true;
        }
    }
    return isNumberInArray;
}

int[] array = GettArray(10, -10, 10);
Console.WriteLine(string.Join(", ", array));
int fint = ReadNumber("Задайте число которое м")