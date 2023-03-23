#include <stdio.h>

int main()
{
    int arrayA[2][3];
    int arrayB[2][3];

    int arraySum[2][3];

    printf("Numbers for ArrayA: \n");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("Enter number for index [%i] [%i]: ", i, j);
            scanf("%i", &arrayA[i][j]);
        }
    }

    printf("Numbers for ArrayB: \n");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("Enter number for index [%i] [%i]: ", i, j);
            scanf("%i", &arrayB[i][j]);
        }
    }

    printf("ArrayA:\n");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%i ", arrayA[i][j]);
        }

        printf("\n");
    }
    
    printf("ArrayB:\n");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%i ", arrayA[i][j]);
        }
        printf("\n");
    }

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arraySum[i][j] = arrayA[i][j] + arrayB[i][j];
        }
    }
    
    printf("ArrayA[2][3] + ArrayB[2][3] = \n");

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%i ", arraySum[i][j]);
        }
        printf("\n");
    }    

    return 0;
}