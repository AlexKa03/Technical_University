#include <stdio.h>

int calculate(int number)
{
    return number * number * number;
}

void main()
{
    int number;

    scanf("%i", &number);

    int result = calculate(number);

    printf("%i", result);
}