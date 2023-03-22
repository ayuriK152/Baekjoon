#include <stdio.h>

int main()
{
	int scoreInput = -1;

	scanf("%d", &scoreInput);

	if (scoreInput == 100 || scoreInput >= 90)
		printf("A");
	else if (scoreInput >= 80)
		printf("B");
	else if (scoreInput >= 70)
		printf("C");
	else if (scoreInput >= 60)
		printf("D");
	else
		printf("F");

	return 0;
}