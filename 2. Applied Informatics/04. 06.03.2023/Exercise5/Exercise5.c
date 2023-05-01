#include <stdio.h>

int main()
{
    int sum = 0;
    int counter = 0;

    printf("Enter positive numbers for suming:\n");

    while (sum <= 15)
    {
        counter++;

        printf("Enter %i number:", counter);

        int number;
        scanf("%i", &number);

        sum += number;    
    }

    printf("After adding %i number sum is over 15 and now is %i", counter, sum);    
}