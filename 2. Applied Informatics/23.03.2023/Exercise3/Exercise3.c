#include <stdio.h>

int main()
{
    int array[2][3] = {{1, 2, 3}, {4, 5, 6}};

    int arrayTransposed[3][2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arrayTransposed[j][i] = array[i][j];
        }
        
    }
       
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            printf("%i ", arrayTransposed[i][j]);
        }
        printf("\n");
    }
    
    return 0;
}