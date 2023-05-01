#include <stdio.h>

int main()
{
    int length = 10;
    int a[10];

    for (int i = 0; i < length; i++)
    {
        a[i] = i * i;

        printf("%i\n", a[i]);
    }
    
}