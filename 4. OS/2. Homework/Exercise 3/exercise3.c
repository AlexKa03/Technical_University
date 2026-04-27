#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main() {
    char filename[100];
    FILE *file;
    int count = 0;
    char ch, prev = '\0';

    printf("Enter the name of the file: ");
    scanf("%99s", filename);

    file = fopen(filename, "r");
    if(file == NULL) {
        printf("File could not be opened.\n");
        return 1;
    }

    while((ch = fgetc(file)) != EOF) {
        if(!isspace(ch) && (isspace(prev) || prev == '\0')) {
            count++;
        }
        prev = ch;
    }

    printf("The file '%s' contains %d words.\n", filename, count);

    fclose(file);
    return 0;
}
