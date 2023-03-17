#include <stdio.h>
#include <stdbool.h>

int main()
{
    int numberFind;
    scanf("%i", &numberFind);

    int array[5];

    for (int i = 0; i < 5; i++)
    {
        scanf("%i", &array[i]);
    }

    bool isntFound = true;

    for (int i = 0; i < 5; i++)
    {
        if (array[i] == numberFind)
        {
            printf("Number %i ws found at index %i", numberFind, i);
            isntFound = false;

            return 0;
        }
    }
    
    if (isntFound)
    {
        printf("Numebr %i wasn't found", numberFind);
    }
}