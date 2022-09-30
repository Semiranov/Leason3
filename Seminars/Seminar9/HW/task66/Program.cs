// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNam(string mess) //метод ввода числа       
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintMtoN(int m, int n)
{
    int sum = 0;
    if (m < n+1)
    {
        if (m == n) return n; 
        sum = m + PrintMtoN(m + 1, n);
    }
    else if (m + 1 > n)
    {
        if (m == n) return n; 
        sum = n + PrintMtoN(m, n + 1);
    }
    else return n;

    return sum;
}

int M = ReadNam("Введите 1е число: ");
int N = ReadNam("Введите 2е число: ");
Console.WriteLine(PrintMtoN(M, N));

