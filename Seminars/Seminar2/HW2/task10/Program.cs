// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int rez = num / 10 % 10;
    Console.WriteLine($"Вторая цифра числа, равна: {rez}"); 
}
else if(num < -99 && num > -1000)
{
    int rez = num / -10 % 10;
    Console.WriteLine($"Вторая цифра числа, равна: {rez}"); 
}
else
{
    Console.WriteLine("Введено не 3х значное число"); 
}