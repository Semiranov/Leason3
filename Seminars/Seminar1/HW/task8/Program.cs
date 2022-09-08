// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 2;

if(num1 > 1)
{
   while(count <= num1)
{
    Console.Write(count + ", ");
    count = count + 2;
}
} 
else
{
    Console.Write("Четных чисел от 1 до " + num1 + " не существует");
} 