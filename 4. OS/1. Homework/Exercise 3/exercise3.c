#include <stdio.h>

int findLargestIndex(int arr[], int n) {
    int i, max_index = 0;
    for(i = 1; i < n; i++) {
        if(arr[i] > arr[max_index])
            max_index = i;
    }
    return max_index;
}

int main() {
    int arr[10], i, n;
    printf("Enter the size of the array:\n");
    scanf("%d", &n);
    printf("Enter the elements of the array:\n");
    for(i = 0; i < n; i++)
        scanf("%d", &arr[i]);
    int largestIndex = findLargestIndex(arr, n);
    printf("Address of the largest element: %p\n", (void*)&arr[largestIndex]);
    return 0;
}
