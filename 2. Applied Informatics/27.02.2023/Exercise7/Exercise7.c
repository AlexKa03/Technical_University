#include <stdio.h>

int main()
{
    printf("H - Home\nN - Next\nP - previous\nE - exit\n");

    char letter;
    scanf(" %c", &letter);

    switch (letter)
    {
    case 'H':
        printf("Home");
        break;
    case 'N':
        printf("Next");
        break;
    case 'P':
        printf("Previous");
        break;
    case 'E':
        printf("Exit");
        break; 
    default:
        printf("Тhere is no such menu");
        break;
    }

    return 0;
}