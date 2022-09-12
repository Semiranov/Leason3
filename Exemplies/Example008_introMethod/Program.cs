int Max(int a,int b,int c)
{
    int res = a;
    if(b > res) res = b;
    if(c > res) res = c;
    return res;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

// int max =a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;

// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;

// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// int raund1 = Max(a1, b1, c1);
// int raund2 = Max(a2, b2, c2);
// int raund3 = Max(a3, b3, c3);
// int final = Max(raund1, raund2, raund3);

int final = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // 

Console.WriteLine(final);



