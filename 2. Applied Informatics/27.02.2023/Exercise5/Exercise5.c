#include <stdio.h>

void main()
{
    int numberOne;
    scanf("%i", &numberOne);

    int numberTwo;
    scanf("%i", &numberTwo);

    int numberThree;
    scanf("%i", &numberThree);

    int biggest;

    if (numberOne > numberTwo)
    {
        if (numberOne > numberThree)
        {
            biggest = numberOne;
        }
        else
        {
            biggest = numberThree;
        }
        
    }
    else
    {
        if (numberTwo > numberThree)
        {
            biggest = numberTwo;
        }
        else
        {
            biggest = numberThree;
        }
    }

    printf("%i", biggest);
}