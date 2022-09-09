// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] array.Length

int[] array = new int[8]; //создали массив на 8 эллементов
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0,2);
    Console.Write(array[i]);
}

