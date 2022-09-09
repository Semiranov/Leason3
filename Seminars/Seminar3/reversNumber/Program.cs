// Разворот числа
int num = 12345;  // исходное число
int tempNum = num; // число которое мы будем разворачивать
int reversedNum = 0; // развернутое число
while(tempNum > 0)
{
    int digit = tempNum % 10;
    reversedNum = reversedNum * 10 + digit;
    tempNum = tempNum / 10;
}
Console.WriteLine($"Развернутое число = {reversedNum}");
