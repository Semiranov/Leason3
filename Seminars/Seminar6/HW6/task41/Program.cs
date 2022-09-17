// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");

bool a = true;
int i = 0;
while(a == true)
{
    string m = Console.ReadLine();
    if(m != "stop" && Convert.ToInt32(m) > 0)
    {
        i++;
    }
    else if(m == "stop")
    {
        a = false;
    }
}

Console.WriteLine("Чисел больше 0 = " + i);
