// Имеется одномерный массив array из n элементов, 
// требуется найти элемент массива, равный find

int[] array = {12, 434, 53, 4, 654, 64, 23, 4, 45, 89};
int n = array.Length;

Console.WriteLine("Введи число которое нужно найти: ");

int find = Convert.ToInt32(Console.ReadLine());
int index = 0;


while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}