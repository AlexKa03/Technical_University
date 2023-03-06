#include <stdio.h>

int main()
{
    int end, counter;

    printf("Enter end of the interval:");
    scanf("%i", &end);

    for (size_t i = 6; i < end; i += 6)
    {
        printf("%i\n", i);
        counter++;
    }
    
    printf("Numbers that are multiples of 6 in the interval from 1 to %i are %i.", end, counter);
}