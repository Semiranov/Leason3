// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


int ReadNam(string mess) //метод ввода числа
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] RandomArr(int lines, int columns, int leftnumrand, int rightnumrund) //метод заполнения массива рандомом
{
    int[,] arr = new int[lines, columns];
    Random rand = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(leftnumrand, rightnumrund);
        }
    }
    return arr;
}

void PrintArr(int[,] arr) //метод печати
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CountingNumbers(int[,] arr) //метод подсчета цифр
{   
    int count = 0;
   for(int num = 0; num < 10; num++)
   {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(num == arr[i, j])
                {
                    count++;
                }
            }      
        }
        if(count > 0)
        {
        Console.WriteLine($"Число {num} встречается {count} раз");
        count = 0;
        }
   }
    
}

int num1 = 3; //ReadNam("Введите колличество строк: ");
int num2 = 4; //ReadNam("Введите колличество столбцов: ");
int[,] array = RandomArr(num1, num2, 0, 9);
PrintArr(array);
Console.WriteLine();
CountingNumbers(array);

