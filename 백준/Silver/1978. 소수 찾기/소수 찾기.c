#include <stdio.h>

int main()
{
	int input, num, count = 0;

	scanf("%d", &input);

	for (int i = 0; i < input; i++)
	{
		int Ncount = 0;
		scanf("%d", &num);
		getchar();

		for (int j = 1; j <= num; j++)
		{
			if (num % j == 0)
				Ncount++;
		}

		if (Ncount == 2)
			count++;
	}

	printf("%d", count);

	return 0;
}