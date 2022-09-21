Console.WriteLine("Введите сумму вклада: ");
double num = Convert.ToDouble(Console.ReadLine());
if(num > 0 && num < 100)
{
    num = num / 5 *100; 
}
else if(num >= 100 && num <=200)
{
    num = num / 7 *100;
}
else if(num > 200)
{
    num = num / 10 *100;
   
}
else
{
    Console.WriteLine("Введен не верный процент"); 
}
Console.WriteLine($"Сумма вклада с процентами равна: {num}"); 
