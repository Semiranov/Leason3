// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintBinaryView(int num)
{
    if(num <= 0) return;
    PrintBinaryView(num / 2);
    Console.Write(num % 2);

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintBinaryView(number);




