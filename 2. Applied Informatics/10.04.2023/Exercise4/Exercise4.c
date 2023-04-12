#include <stdio.h>

int main()
{
    int array[6] = {1, 2, 3, 4, 5,6 };
    float average;

    average = averageCalculator(array, 6);

    printf("Average value of the array is: %f", average);
}

int  averageCalculator(int *array, int length)
{
    float average;

    for (int i = 0; i < length; i++)
    {
        average += array[i];
    }

    average /= length;
    return average;
}