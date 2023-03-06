#include <stdio.h>

int main()
{
    int n;
    scanf("%i", &n);

    int sum;

    while (n > 0)
    {
        if (n % 2 == 0)
        {
            sum += n;
            n -= 2;
        }
        else
        {
            n-= 1;
        }
    }

    printf("%i", sum);
}