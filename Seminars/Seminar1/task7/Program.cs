// 7. Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int digit = number % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
