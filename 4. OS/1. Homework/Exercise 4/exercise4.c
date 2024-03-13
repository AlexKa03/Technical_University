#include <stdio.h>

void printArrayWithoutBrackets(int *arr, int n) {
    for(int i = 0; i < n; i++) {
        printf("%d ", *(arr + i));
    }
    printf("\n");
}

int main() {
    int arr[10], i, n;
    printf("Enter the size of the array:\n");
    scanf("%d", &n);
    printf("Enter the elements of the array:\n");
    for(i = 0; i < n; i++)
        scanf("%d", &arr[i]);
    printArrayWithoutBrackets(arr, n);
    return 0;
}
