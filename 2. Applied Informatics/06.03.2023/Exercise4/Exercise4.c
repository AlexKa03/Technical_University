#include <stdio.h>

int main()
{
    int y = 0;
    int x = 0;

    int b, k;
    scanf("%i", &b);  
    scanf("%i", &k);

    y = k;

    while (y < 10)
    {
        x += 3;
        y = b * x + k;
        printf("%i\n", x);
        printf("%i\n", y);
    }
    
}