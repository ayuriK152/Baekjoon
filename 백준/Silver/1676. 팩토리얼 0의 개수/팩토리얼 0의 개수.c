#include <stdio.h>

int main()
{
	int input;

	scanf("%d", &input);
	printf("%d", makeFactorial(input));

	return 0;
}

int makeFactorial(int num)
{
	int temp;
	int count = 0;
	int two = 0, five = 0;
	for (int i = 1; i <= num; i++)
	{
		temp = i;
		if (temp % 2 == 0)
		{
			while (temp % 2 == 0)
			{
				two++;
				temp /= 2;
			}
		}
		if (temp % 5 == 0)
		{
			while (temp % 5 == 0)
			{
				five++;
				temp /= 5;
			}
		}
		if (two >= 1 && five >= 1)
		{
			while (two >= 1 && five >= 1)
			{
				two--;
				five--;
				count++;
			}
		}
	}
	return count;
}