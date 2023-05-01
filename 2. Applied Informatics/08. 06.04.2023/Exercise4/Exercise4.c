#include <stdio.h>

int fibonacci(int n) {
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}

int main() {
    int num;
    
    printf("Enter a positive integer: ");
    scanf("%d", &num);

    printf("Fibonacci numbers up to %d are:\n", num);

    int sum = 0;

    for (int i = 0; i <= num; i++) {
        int fib = fibonacci(i);
        printf("%d ", fib);
        sum += fib;
    }

    printf("\nSum of Fibonacci numbers up to %d is: %d\n", num, sum);

    return 0;
}