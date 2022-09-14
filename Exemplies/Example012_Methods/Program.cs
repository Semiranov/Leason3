//1
void Method1()  // метод ничего не принимает и не возвращает
{
    Console.WriteLine("Текст сообщения");
}
Method1();

//2
void Method2(string mes) // метод принимает аргумент и ни чего не возвращает
{
    Console.WriteLine(mes);
}
Method2("Текст сообщения");

//3
int Method3() // метод ничего не принимает но возвращает аргумент
{
    return DateTime.Now.Year;
}
 int date = Method3();
 Console.WriteLine(date);
 
//4
 string Method4(string str, int n) // Метод и принимает и возвращает аргумент
 {
    string res = String.Empty;
    for( int i = 0; i < n; i++)
    {
        res = res + str; 
    }
    return res;
 }
 string result = Method4("Мой текст; ", 5);
 Console.WriteLine(result);