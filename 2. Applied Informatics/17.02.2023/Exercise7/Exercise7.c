#include <stdio.h>
int main(void)
{
    int a;
    printf("Enter a: ");
    scanf("%i", &a);

    int b;
    printf("Enter b: ");
    scanf("%i", &b);

    int c;
    printf("Enter c: ");
    scanf("%i", &c);

    int result = (a + b) * c;

    printf("%i = (%i + %i) * %i", result, a, b, c);
}