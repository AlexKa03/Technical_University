#include <stdio.h>

long long factorial(int n) {
    if (n == 0)
        return 1;
    else
        return n * factorial(n - 1);
}

int main() {
    int n = 5;
    printf("Факториел на %d е: %lld\n", n, factorial(n));
    return 0;
}
