#include <stdio.h>

void main()
{
    int numberOne;
    scanf("%i", &numberOne);

    int numberTwo;
    scanf("%i", &numberTwo);

    if ((numberOne == 100 && numberTwo == 200) ||
        (numberOne == 200 && numberTwo == 100))
    {
        int sum = numberOne + numberTwo;
        printf("%i\n", sum);
    }
    
    printf("Number one: %i\nNumber two:%i", numberOne, numberTwo);
}