#include <stdio.h>

int main()
{
    printf("The value of a: ");
    int a;
    scanf("%i", &a);

    int *pOne, **pTwo;
    pOne = &a;
    pTwo = &pOne;

    printf("The value of *pOne = %i\n", *pOne);
    printf("The value of *pTwo = %i", **pTwo);
}