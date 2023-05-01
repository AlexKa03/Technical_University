#include <stdio.h>

void findEvenElements(int rows, int cols, int matrix[100][100])
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i][j] % 2 == 0)
            {
                printf("Елемент на позиция [%d][%d] = %d\n", i, j, matrix[i][j]);
            }
        }
    }
}

int main()
{
    printf("Задание 2: Да се напише подпрограма функция за намиране на четните елементи на двумерен масив. Подпрограмата функция да се извика два пъти от главната програма с различни стойности на аргументите. \n");
    printf("Имена: Александър Николаев Кадийски\n");
    printf("Фак. номер: 471222067\n");

    int rows, cols;
    printf("");
    printf("Въведете редовете (x) за матрицата: ");
    scanf("%i", &rows);
    printf("Въведете колоните (y) за матрицата: ");
    scanf("%i", &cols);

    int matrix[100][100];  
    printf("Въведете числата заматрицата: \n");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            printf("Въведете число на позиция [%i][%i]: ", i, j);
            scanf("%i", &matrix[i][j]);
        }
    }

    printf("Четни елементи в масива са:\n");
    findEvenElements(rows, cols, matrix);
    printf("\n---------------------------------------------------\n\n");

    printf("Въведете редовете (x) за матрицата: ");
    scanf("%i", &rows);
    printf("Въведете колоните (y) за матрицата: ");
    scanf("%i", &cols);

    matrix[100][100];  
    printf("Въведете числата заматрицата: \n");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            printf("Въведете число на позиция [%i][%i]: ", i, j);
            scanf("%i", &matrix[i][j]);
        }
    }
    printf("Четни елементи в масива са:\n");
    findEvenElements(rows, cols, matrix);
    printf("\n");

    return 0;
}