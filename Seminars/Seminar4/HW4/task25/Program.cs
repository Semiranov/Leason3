// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

double vivod(string a)
{
    Console.WriteLine(a);
    double b = Convert.ToDouble(Console.ReadLine());
    return b;
}

double num = vivod("Введите число 1: ");
double num2 = vivod("Введите число 2: ");
double num3 = num;

if(num2 >= 0)
{
    for(int i = 1; i < num2; i++)
    {
        num3 = num3 * num;
    }
    Console.WriteLine($"{num} в степени {num2} равно: {num3}");
}
else
{
    Math.Abs(num2);
    for(int i = 1; i < num2; i++)
    {
        num3 = num3 * num;
    }
    Console.WriteLine($"{num} в степени {num2} равно: {1/num3}");
}
