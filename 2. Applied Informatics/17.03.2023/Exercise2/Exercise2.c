#include <stdio.h>

int main()
{
    int a[6];
    int length = 6;

    float sum;

    for (int i = 0; i < length; i++)
    {
        int number;
        scanf("%i", &number);

        a[i] = number;
        sum += number;
    }

    sum /= length;

    printf("%.2f", sum);
}