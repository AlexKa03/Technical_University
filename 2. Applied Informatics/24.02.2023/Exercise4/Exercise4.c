#include <stdio.h>

void main()
{
    int a = 100;
    float b = 331.79;
    double c = 8.44e+11;
    char d = 'A';
    _Bool e = 0;

    printf("a = %i\n", a);
    printf("b = %f\n", b);
    printf("c = %f\n", c);
    printf("d = %c\n", d);
    printf("e = %s\n", e? "true":"false");
}