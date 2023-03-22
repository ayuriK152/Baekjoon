#include <stdio.h>

int main()
{
	int userInput = -1;

	scanf("%d", &userInput);
	for (int i = 1; i <= 9; i++)
	{
		printf("%d * %d = %d\n", userInput, i, userInput * i);
	}
	return 0;
}