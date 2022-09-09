// Задача 26: Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumbers(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfDigits(int num)
{
    int count = 0;    //кол-во итераций цикла
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int number = ReadNumbers("Введите число: ");
int count = GetCountOfDigits(number);
Console.WriteLine(count);
