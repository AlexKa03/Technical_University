#include <stdio.h>

int main()
{
    int sum;

    for (int i = 1; i <= 10; i++)
    {
        sum += i;
        printf("%i + %i = %i\n", sum - i, i, sum);
    }
}