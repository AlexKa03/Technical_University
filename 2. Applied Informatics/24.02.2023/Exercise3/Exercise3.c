#include <stdio.h>

void main()
{
    int a = 25;
    int b = 5;
    int c = 10;
    int d = 7;

    int equationOne = a % b;
    printf("a %% b = ");
    printf("%i\n", equationOne);

    int equationTwo = a % d;
    printf("a %% d = ");
    printf("%i\n", equationTwo);

    int equationThree = a % c;
    printf("a %% c = ");
    printf("%i\n", equationThree);
    
    int equationFour = a / d * d + a % d;
    printf("a / d * d + a %% d = ");
    printf("%i\n", equationFour);
}