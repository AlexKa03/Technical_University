#include <stdio.h>

#define N 4

void spiralPrint(int m, int n, int a[N][N]) {
    int i, k = 0, l = 0;

    while (k < m && l < n) {
        for (i = l; i < n; ++i) {
            printf("%d ", a[k][i]);
        }
        k++;

        for (i = k; i < m; ++i) {
            printf("%d ", a[i][n-1]);
        }
        n--;

        if (k < m) {
            for (i = n-1; i >= l; --i) {
                printf("%d ", a[m-1][i]);
            }
            m--;
        }

        if (l < n) {
            for (i = m-1; i >= k; --i) {
                printf("%d ", a[i][l]);
            }
            l++;
        }
    }
}

int main() {
    int a[N][N] = {{1, 2, 3, 4},
                   {6, 10, 8, 9},
                   {11, 2, 3, 4},
                   {3, 7, 4, 5}};

    spiralPrint(N, N, a);
    return 0;
}
