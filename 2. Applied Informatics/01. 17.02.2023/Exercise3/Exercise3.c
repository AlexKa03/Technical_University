#include <stdio.h>

int main()
{
    int numOne;
    printf("Enter first number: ");
    scanf("%i", &numOne);

    int numTwo;
    printf("Enter two number: ");
    scanf("%i", &numTwo);

    int sub = numOne - numTwo;
    printf("The subtraction of %i and %i is %i", numOne, numTwo, sub);

    return 0;
}