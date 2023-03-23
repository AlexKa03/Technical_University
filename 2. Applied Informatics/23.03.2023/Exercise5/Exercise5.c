#include <stdio.h>

int main()
{
    int cityTemperatures[2][3];

    printf("Enter temperatures for first city:\n");

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("City %i, Day %i: ", i + 1, j + 1);
            scanf("%i", &cityTemperatures[i][j]);
        }   
    }
    
    printf("The temeperatures per city and day are:\n");

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("City %i, Day %i = %i\n", i + 1, j + 1, cityTemperatures[i][j]);
        }      
    }

    return 0;
}