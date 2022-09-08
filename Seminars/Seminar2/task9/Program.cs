// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine(number);
int num2 = number % 10;
int num1 = number / 10;
if(num1 >= num2)
{
   Console.WriteLine($"Цифра {num1} наибольшая"); 
}
else
{
    Console.WriteLine($"Цифра {num2} наибольшая");
}