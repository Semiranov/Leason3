// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Координаты 1й четверти: x > 0, y > 0 ");
}
else if (num == 2)
{
    Console.WriteLine("Координаты 2й четверти: x < 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("Координаты 3й четверти: x < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Координаты 4й четверти: x > 0, y < 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}