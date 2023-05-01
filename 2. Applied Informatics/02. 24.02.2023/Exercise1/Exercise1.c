#include <stdio.h>

void main()
{
    float farenhait;
    scanf("%f", &farenhait);
    
    float celsius = (farenhait - 32) / 1.8;

    printf("%.2f", celsius);

    return 0;
}