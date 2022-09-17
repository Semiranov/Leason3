// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
//  суммы двух других сторон

Console.WriteLine("Введите 1е число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int number3 = Convert.ToInt32(Console.ReadLine());

string Triangle(int num1, int num2, int num3)  // Метод проверки сущесствования треугольника
{
    string res = "Треугольник существовать не может";
    if(num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2))
    {
        res = "Треугольник существовать может";
    }
    return res;
}

Console.WriteLine(Triangle(number1, number2, number3));