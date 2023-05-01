#include <stdio.h>
#include <limits.h>

void fastestProgrammer(int totalHours[])
{
    int time = INT_MAX;
    int programmer;

    for (int i = 0; i < 3; i++)
    {
        if (totalHours[i] < time)
        {
            time = totalHours[i];
            programmer = i + 1;
        }
        
    }

    printer(time, programmer);
}

void printer(int time, int programmer)
{
    printf("Най- бърз програмист е %i-ят с време: %i часа!", programmer, time);
}

int main()
{
    printf("Имена: Александър Николаев Кадийски\n");
    printf("Фак. номер: 471222067\n");
    printf("Използвайки част от кода от предната задача, напишете подпрограмна функция за изчисляване кой програмист си е написал кода най- бързо\n");

    int totalHours[3];

    for (int i = 0; i < 3; i++) {
        printf("Въведете времето, което програмист %i е писал кода: ", i + 1);
        scanf("%i", &totalHours[i]);
    }

    fastestProgrammer(totalHours);
    
    return 0;
}