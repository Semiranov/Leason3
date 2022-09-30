// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNam(string mess) //метод ввода числа       
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int m, int n) //метод аккермана
{
    int ak = 0;
    if (m == 0)
    {
       ak = n + 1;
    }
    else if (m > 0 && n == 0)
    {
       ak = AkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
       ak = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else
    {
        Console.WriteLine("Ошибка");
    }

    return ak;
}

int M = ReadNam("Введите M: ");
int N = ReadNam("Введите N: ");
Console.WriteLine(AkkermanFunction(M, N));