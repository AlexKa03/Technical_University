#include <stdio.h>

int powerF(int base, int power)
{    
    if (power == 0)
    {
        return 1;
    }
    
    return base * powerF(base, --power);
}

int main()
{
    int base, power;
    scanf("%i", &base);
    scanf("%i", &power);

    printf("Number after power is: %i", powerF(base, power));

    return 0;
}