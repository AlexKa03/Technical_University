#include <stdio.h>

int main()
{
    int arrayA[5] = {5, 2, 1, 4, 6};
    int arratB[5];

    for (int i = 0; i < 5; i++)
    {
        arratB[i] = arrayA[i];

        printf("%i ", arratB[i]);
    }
    
}