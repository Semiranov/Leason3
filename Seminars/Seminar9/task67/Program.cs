// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNam(string mess) //метод ввода числа       
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int SummNum(int m)
{
    int sum = 0;
    if(m == 0)
    {
        return 0 ;
    }
    else
    {
        sum = m % 10 + SummNum(m / 10);
        return sum;
    }
   
}

int number = ReadNam("Введите M");
Console.WriteLine(SummNum(number));



