#include <stdio.h>

void main()
{
    int numOne;
    printf("Enter intger - ");
    scanf("%i", &numOne);

    double numTwo;
    printf("Enter float number - ");
    scanf("%lf", &numTwo);
    
    double numThree;
    printf("Enter exponential number - ");
    scanf("%le", &numThree);

    char letter;
    printf("Enter letter - ");
    scanf(" %c", &letter);

    printf("num1: %i\n", numOne);
    printf("num2: %f\n", numTwo);
    printf("num3: %e\n", numThree);
    printf("letter: %c\n", letter);

    return 0;
}