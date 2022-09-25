﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void ArrayOutput(int[,,] arr) //вывод массива
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i,j,k]}({i},{j},{k})");
            }
        }

    }
}

int[ , , ] array = {
	{
	   { 32, 76 },
	   { 39, 59 },
	},
	{
	   { 93, 77 },
	   { 62, 45 },
	}
};

ArrayOutput(array);
