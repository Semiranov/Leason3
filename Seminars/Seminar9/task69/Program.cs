// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNam(string mess) //метод ввода числа       
{
    Console.WriteLine(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int Sqrt(int a, int b)
{
   if(b == 0)
   return 1;
   else
   {
    return a * Sqrt(a, b - 1);
   }
}

int A = ReadNam("Введите 1е число");
int B = ReadNam("Введите 2е число");
Console.WriteLine(Sqrt(A,B));


