#include <stdio.h>

void main()
{
    int number;
    scanf("%i", &number);

    if (number == 0)
    {
        printf("The number is Zero");
    }
    else if(number > 0)
    {
        printf("The number is Positive");
    }  
    else
    {
        printf("The number is Negative");
    }

    return 0;
}