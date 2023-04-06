#include <stdio.h>
#include <stdbool.h>

_Bool isPrime(int number, int index)
{
    if (number < 2)
    {
        return false;
    }
    if (index * index > number)
    {
        return true;
    }
    if (number % index == 0)
    {
        return false;
    }
    
    isPrime(number, index + 1);
}

int main()
{
    int number;
    printf("Enter positive integer: ");
    scanf("%i", &number);

    _Bool result = isPrime(number, 2);

    if (result)
    {
        printf("The number %i is prime.", number);
    }
    else
    {
        printf("The number %i is not prime.", number);
    }
}