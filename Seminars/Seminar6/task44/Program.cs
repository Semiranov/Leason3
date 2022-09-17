// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Fibo(number);

void Fibo(int num)
{
    if(num >= 2)
    {
    int a = 0;
    int b = 1;
    int c = 1;
    Console.Write(a);
    Console.Write(b);
    for(int i = 2; i < num; i++)
    {
        c = a + b;
        Console.Write(c);
        a = b;
        b = c;
    }
    }
    else 
    {
        Console.Write("");
    }

}
