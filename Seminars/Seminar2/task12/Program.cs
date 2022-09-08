// Задача 12: Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 != 0)
{
    int i = num1 % num2; 
    if(i == 0)
    {
       Console.WriteLine($"Число {num1} кратно числу {num2}"); 
    }
    else
    {
       Console.WriteLine($"Число {num1} не кратно числу {num2}, остаток {i}");  
    }
}
else
{
    Console.WriteLine("На 0 делить нельзя!"); 
}