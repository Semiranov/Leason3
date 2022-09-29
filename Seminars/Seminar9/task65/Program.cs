// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNam(string mess) //метод ввода числа
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMtoN(int m, int n)
{
    if(m > n)
    {
        return;
    }
    PrintMtoN(m, n - 1);
    Console.Write(n + " ");
}

int numberM = ReadNam("Введите M");
int numberN = ReadNam("Введите N");

PrintMtoN(numberM, numberN);

