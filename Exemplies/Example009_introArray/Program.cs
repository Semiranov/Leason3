int Max(int a,int b,int c)
{
    int res = a;
    if(b > res) res = b;
    if(c > res) res = c;
    return res;
}

int[] array = {17, 223, 366, 45, 5, 643, 76, 438, 91};

int final = Max(Max(array[0], array[1], array[2]), 
            Max(array[3], array[4], array[5]), 
            Max(array[6], array[7], array[8])); // 

Console.WriteLine(final);




