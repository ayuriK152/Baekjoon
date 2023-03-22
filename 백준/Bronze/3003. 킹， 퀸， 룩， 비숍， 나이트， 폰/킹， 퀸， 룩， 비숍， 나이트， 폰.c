#include<stdio.h>

int main(void)
{
    int Black_Chees[6] = {1, 1, 2, 2, 2, 8};
    int White_Chees[6];
    for(int i = 0; i < 6; ++i){
        scanf("%d ", &White_Chees[i]);
    }
    for(int i = 0; i < 6; i++){
        printf("%d ", Black_Chees[i] - White_Chees[i]);
    }

    return 0;
}