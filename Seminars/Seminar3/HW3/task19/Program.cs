// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 9999 && num < 100000)
{
    if(num / 10000 == num % 10)
    {
        if(num / 1000 % 10 == num % 100 / 10)
        {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("Число НЕ палиндром");
        }
    }
    else
        {
            Console.WriteLine("Число НЕ палиндром");
        }
}
else if(num < 0)
{
    Console.WriteLine("Введено отрицательное число!");
}
else
{
    Console.WriteLine("Введено не пятизначное число!");
}