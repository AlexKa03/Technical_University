#include <stdio.h>

void names(char first[], char second[], char last[])
{
    printf("First name: %s\nSecond name: %s\nLast name: %s", first, second, last);  
}

void main()
{
    printf("Enter your names: ");
    char first[20], second[20], last[20];

    scanf("%s %s %s", first, second, last);

    names(first, second, last);  
}