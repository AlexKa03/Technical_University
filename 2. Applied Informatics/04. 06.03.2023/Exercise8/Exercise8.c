#include <stdio.h>

int main()
{
    char letter;

    printf("Chose\nA - Abs\nS - Sin\nC - cos\nE - Exit\n");

    do
    {
        scanf(" %c", &letter);

        switch (letter)
        {
        case 'A':
        printf("Absolute value\n");
            break;
        case 'S':
        printf("Sinus\n");
            break;
        case 'C':
        printf("Cosinus\n");
            break;      
        case 'E':
        printf("Exit\n");
            break;
        default:
        printf("There is no such command\n");
            break;
        }

    } while (letter != "E");
    
}