#include <stdio.h>

int sum(int number)
{    
    if (number == 1)
    {
        return 1;
    }
    
    return number + sum(number - 1);
}

int main()
{
    int number;
    scanf("%i", &number);

    printf("The result is: %i", sum(number));

    return 0;
}