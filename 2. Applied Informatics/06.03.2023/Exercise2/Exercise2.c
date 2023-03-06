#include <stdio.h>

int main()
{
    int n;
    scanf("%i", &n);

    int sum;

    if (n >= 1)
    {      
    for (int i = 1; i <= n; i++)
    {
        sum += i;
        printf("%i + %i = %i\n", sum - i, i, sum);
    }
    }
    else
    {
        printf("You need to enter possitive number");
    }
}