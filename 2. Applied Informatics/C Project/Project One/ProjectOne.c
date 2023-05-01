#include <stdio.h>

int main()
{    
    printf("Задание 1: Да се състави блокова схема на алгоритъм и да се напише програма за умножаване на две матрици.В началото на програмата да се отпечати заданието, името на студента и фак. номер.\n");
    printf("Имена: Александър Николаев Кадийски\n");
    printf("Фак. номер: 471222067\n");

    int rowsOne, colsOne;
    printf("Въведете редовете (x) за матрица А: ");
    scanf("%i", &rowsOne);
    printf("Въведете колоните (y) за матрица А: ");
    scanf("%i", &colsOne);

    int rowsTwo, colsTwo;
    printf("Въведете редовете (m) за матрица B: ");
    scanf("%i", &rowsTwo);
    printf("Въведете колоните (n) за матрица B: ");
    scanf("%i", &colsTwo);  
    
    if (colsOne != rowsTwo)
    {
        printf("Няма как две матрици с различни размери да се умножат.");
    }
    else
    {
        int matrixOne[100][100];  
        printf("Въведете числата заматрица A:\n");
        for (int i = 0; i < rowsOne; i++)
        {
            for (int j = 0; j < colsOne; j++)
            {
                printf("Въведете число на позиция [%i][%i]: ", i, j);
                scanf("%i", &matrixOne[i][j]);
            }
        }

        int matrixTwo[100][100];  
        printf("Въведете числата заматрица B:\n");
        for (int i = 0; i < rowsTwo; i++)
        {
            for (int j = 0; j < colsTwo; j++)
            {
                printf("Въведете число на позиция [%i][%i]: ", i, j);
                scanf("%i", &matrixTwo[i][j]);
            }
        }

        printf("Решение:\n");
        for (int i = 0; i < rowsOne; i++)
        {
            for (int j = 0; j < colsOne; j++)
            {
                printf("%i ", matrixOne[i][j]);
            }
            if (i == rowsOne / 2)
            {
                printf("  *");
            }

            printf("\n");
        }
        printf("\n");  

        for (int i = 0; i < rowsTwo; i++)
        {
            for (int j = 0; j < colsTwo; j++)
            {
                printf("%i ", matrixTwo[i][j]);
            }
            if (i == rowsTwo / 2)
            {
                printf("  =");
            }

            printf("\n");
        }   
        printf("\n");

        int multiplicated[100][100];
        for (int i = 0; i < rowsOne; i++) 
        {
            for (int j = 0; j < colsTwo; j++) 
            {
                multiplicated[i][j] = 0;
                for (int k = 0; k < colsOne; k++)
                {
                    multiplicated[i][j] += matrixOne[i][k] * matrixTwo[k][j];                 
                }

                printf("%i ", multiplicated[i][j]);
            }

            printf("\n");
        }        
    }

    return 0;
}