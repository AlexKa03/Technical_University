#include <stdio.h>
#include <limits.h>

int main()
{
    int arrayLength;
    scanf("%i", &arrayLength);

    int array[1000];

    for (int i = 0; i < arrayLength; i++)
    {
        scanf("%i", &array[i]);
    }
    
    int maxValue = INT_MIN;

    for (int i = 0; i < arrayLength; i++)
    {
        if(array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    
    printf("Biggest number: %i", maxValue);
}