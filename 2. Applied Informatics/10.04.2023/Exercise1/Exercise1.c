#include <stdio.h>

int main()
{
    int iOne, iTwo;
    int *pOne, **pTwo;

    iOne = 8;
    pOne = &iOne;
    
    iTwo = (*pOne / 4) + 15;
    pTwo = &pOne;

    printf("i1 = %i, i2 = %i, *p1 = %d, *p2 = %d", iOne, iTwo, *pOne, **pTwo);
}