#include <stdio.h>

void main()
{
    int number;
    scanf("%i", &number);
    
    if (number < 0)
    {
        number *= -1;
    }

    printf("%i", number);    

    return 0;
}