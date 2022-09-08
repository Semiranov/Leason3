// Задача 21: Напишите программу, которая принимает на вход
//  координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Math.Pow(num, 2) -  переменная в квадрате    Math.Sqrt(num) -  квадратный корень

Console.WriteLine("Введите первую координату точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine()); //координата X1
Console.WriteLine("Введите вторую координату точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());  //координата Y1

Console.WriteLine("Введите первую координату точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());   //координата X2
Console.WriteLine("Введите вторую координату точки B: ");
int By = Convert.ToInt32(Console.ReadLine());   //координата Y2

double rez = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));  // вычисление по формуле
Console.WriteLine($"Расстояние между точками A и B равно: {rez}");
