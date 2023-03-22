#include <stdio.h>

int main()
{
	int input;

	scanf("%d", &input);

	if ((input % 5) % 3 == 0)
		printf("%d", ((input / 5) + ((input % 5) / 3)));

	else if ((input % 5) % 3 == 1 && input / 5 > 0)
		printf("%d", (((input / 5) - 1) + (((input % 5) + 5) / 3)));
	
	else if ((input % 5) % 3 == 2 && input / 5 > 1)
		printf("%d", (((input / 5) - 2) + (((input % 5) + 10) / 3)));

	else
		printf("-1");

	return 0;
}