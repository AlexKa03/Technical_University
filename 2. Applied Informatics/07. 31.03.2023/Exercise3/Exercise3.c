#include <stdio.h>

int sum(int numbers[])
{
    int smallest = numbers[0];

    for (int i = 1; i < 10; i++)
    {
        if (smallest > numbers[i])
        {
            smallest = numbers[i];
        }
    }

    return smallest;
    
}

void main()
{
    int numbers[10];

    for (int i = 0; i < 10; i++)
    {
        scanf("%i", &numbers[i]);
    }
    
    int result = sum(numbers);

    printf("Smallest number: %i", result);
}