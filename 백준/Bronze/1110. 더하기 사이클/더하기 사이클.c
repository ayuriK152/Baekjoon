#include <stdio.h>

int main()
{
	int num;
	int initNum;
	int count = 0;

	scanf("%d", &num);

	if (num < 10)
		num += 10 * num;

	initNum = num;

	while (1)
	{
		count++;
		num = (num / 10 + num % 10) % 10 + (num % 10) * 10;
		if (num == initNum)
			break;
	}

	printf("%d", count);

	return 0;
}