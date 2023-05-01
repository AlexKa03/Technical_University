#include <stdio.h>

int main()
{
    int row;
    int column;

    printf("Enter number for rows: ");
    scanf("%i", &row);

    printf("Enter number for columns: ");
    scanf("%i", &column);

    int array[100][100];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            printf("Number for index [%i] [%i]: ", i, j);
            scanf("%i", &array[i][j]);
        }
    }

    printf("\n");

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            printf("%i ", array[i][j]);
        }        

        printf("\n");
    }  

    return 0; 
}