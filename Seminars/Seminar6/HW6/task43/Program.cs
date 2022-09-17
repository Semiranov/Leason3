// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNum(string mes)  // метод ввода числа
{
    Console.WriteLine(mes);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

string Dot(double a, double c, double b, double d)  // метод нах. точки пересечения
{
    string res = string.Empty; 
    double x, y = 0;
    if(a != b)
    {
        x = (d - c) / (a - b);
        y = a * (d - c) / (a - b) + c;
        res = Convert.ToString(x +"; "+ y);
    }
    else
    {
        res = "Прямые параллельны";
    }
    return res;
}

double a = EnterNum("ВВедите значение k1");
double c = EnterNum("ВВедите значение b1");
double b = EnterNum("ВВедите значение k2");
double d = EnterNum("ВВедите значение b2");

Console.WriteLine(Dot(a,c,b,d));

