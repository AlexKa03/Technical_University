#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_ROWS 25
#define MAX_LENGTH 1000

void bubbleSort(char arr[][MAX_LENGTH], int n) {
    for(int i = 0; i < n-1; i++) {
        for(int j = 0; j < n-i-1; j++) {
            if(strcmp(arr[j], arr[j+1]) > 0) {
                char temp[MAX_LENGTH];
                strcpy(temp, arr[j]);
                strcpy(arr[j], arr[j+1]);
                strcpy(arr[j+1], temp);
            }
        }
    }
}

int main() {
    char strings[MAX_ROWS][MAX_LENGTH];
    int n = 0;

    printf("Enter up to %d lines (press enter on an empty line to finish):\n", MAX_ROWS);
    while(n < MAX_ROWS && fgets(strings[n], MAX_LENGTH, stdin)) {
        if(strings[n][0] == '\n') break;
        strings[n][strlen(strings[n]) - 1] = '\0'; // Remove newline character
        n++;
    }

    bubbleSort(strings, n);

    printf("Sorted lines:\n");
    for(int i = 0; i < n; i++) {
        printf("%s\n", strings[i]);
    }

    return 0;
}
