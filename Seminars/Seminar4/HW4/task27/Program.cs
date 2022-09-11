// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int vivod(string a)  // метод ввода и вывода числа
{
    Console.WriteLine(a);
    int number = Convert.ToInt32(Console.ReadLine());
    return Math.Abs(number);
}

int summa(int num)  // метод суммы чисел
{
    int res = 0;
    while(num > 0)
    {
        res = res + (num % 10);
        num = num / 10;
    }
    return res;
}

int num = vivod("Введите число: ");
int sum = summa(num);
Console.WriteLine("Сумма чисел равна: " + sum);