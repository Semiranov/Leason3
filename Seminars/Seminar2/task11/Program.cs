// 11. Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);
int num3 = number % 10;
int num1 = number / 100;
int res = num1 * 10 + num3;
Console.WriteLine(res);