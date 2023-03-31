#include <stdio.h>

int sum(int numbers[])
{
    int sum = 0;

    for (int i = 0; i < 10; i++)
    {
        sum += numbers[i];
    }
    
    return sum;
}

void main()
{
    int numbers[10];

    for (int i = 0; i < 10; i++)
    {
        scanf("%i", &numbers[i]);
    }
    
    int result = sum(numbers);

    printf("Sum: %i", result);
}