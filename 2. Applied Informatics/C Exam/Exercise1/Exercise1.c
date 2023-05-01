#include <stdio.h>

int main()
{
    printf("Имена: Александър Николаев Кадийски\n");
    printf("Фак. номер: 471222067\n");
    printf("Да се напише програма за намиране на средното време (в часове) за написване на един програмен код от 3 програмиста в рамките на 5 раб. дни\n");

    float totalHours[3];
    float sumHours = 0;

    for (int i = 0; i < 3; i++) {
        printf("Въведете времето, което програмист %i е писал кода: ", i + 1);
        scanf("%f", &totalHours[i]);
        sumHours += totalHours[i];
    }

    float averageTime = sumHours / (5 * 3);
    printf("%f %f", sumHours, averageTime);
    printf("Средното прекарано време в писане на код от 3-мата програмиста за 5 дни е: %.2f часа\n", averageTime);

    return 0;
}