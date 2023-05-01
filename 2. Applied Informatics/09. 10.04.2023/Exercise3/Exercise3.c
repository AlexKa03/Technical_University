#include <stdio.h>

int main()
{
    int a,b;

    printf("Enter value of a: ");
    scanf("%i", &a);

    printf("Enter value of b: ");
    scanf("%i", &b);

    changeValue(&a, &b);

    printf("a = %i\nb = %i", a, b);
}

void changeValue(int *a, int *b)
{
    int temp;
    temp = *a;
    *a = *b;
    *b = temp;
}