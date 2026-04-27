#include <stdio.h>

int main() {
    int x, y;
    printf("Enter two numbers:\n");
    scanf("%d %d", &x, &y);
    printf("Address of x: %p\nAddress of y: %p\n", (void*)&x, (void*)&y);
    return 0;
}