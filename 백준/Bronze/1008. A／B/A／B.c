#include <stdio.h>

int main()
{
	int a, b; //입력값
	scanf("%d%d", &a, &b);
	printf("%.20f", a/(double)b);
	return 0;
}