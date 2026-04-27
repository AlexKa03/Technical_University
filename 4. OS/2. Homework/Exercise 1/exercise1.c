#include <stdio.h>
#include <stdlib.h>

int main() {
    int n;
    float *numbers;
    float min, max;

    printf("Enter the number of elements: ");
    scanf("%d", &n);

    if(n <= 0) {
        printf("Number of elements must be greater than 0.\n");
        return 1;
    }

    numbers = (float*)malloc(n * sizeof(float));
    if(numbers == NULL) {
        printf("Memory allocation failed!\n");
        return 1;
    }

    printf("Enter %d real numbers: ", n);
    for(int i = 0; i < n; i++) {
        scanf("%f", &numbers[i]);
        if(i == 0) {
            min = max = numbers[i];
        } else {
            if(numbers[i] < min) min = numbers[i];
            if(numbers[i] > max) max = numbers[i];
        }
    }

    printf("Minimum number: %.2f\n", min);
    printf("Maximum number: %.2f\n", max);

    free(numbers);
    return 0;
}
