#include <stdio.h>

int factorial(int number)
{    
    if (number == 1)
    {
        return 1;
    }
    
    return number * factorial(number - 1);
}

int main()
{
    int number;
    scanf("%i", &number);

    printf("Factorial is: %i", factorial(number));

    return 0;
}