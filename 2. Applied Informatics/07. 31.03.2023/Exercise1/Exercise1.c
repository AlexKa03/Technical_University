#include <stdio.h>

int calculate(int a, int b)
{
    return a+b;
}

void main()
{
    int a,b;

    scanf("%i", &a);
    scanf("%i", &b);

    int result = calculate(a, b);

    printf("%i", result);
}