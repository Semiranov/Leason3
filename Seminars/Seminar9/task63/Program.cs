// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadNam(string mess) //метод ввода числа
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

void Print1toN(int n) //рекурсия n+1
{
    if(n <= 0)
    {
        return;
    }
    else
    {
        Print1toN(n - 1);
        Console.Write(n + " ");
    }
}

int number = ReadNam("Введите N");
Print1toN(number);
