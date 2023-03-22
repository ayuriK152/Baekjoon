#include <stdio.h>

int main()
{
	int input[3];
	int counts[10] = { 0, };
	int result, digits;

	scanf("%d", &input[0]);
	scanf("%d", &input[1]);
	scanf("%d", &input[2]);

	result = input[0] * input[1] * input[2];

	for (int i = 1; result / i >= 1;)
	{
		digits = i;
		i *= 10;
	}

	for (int j = 0; digits >= 1; j++)
	{
		int count = 0;

		while (result - digits >= 0)
		{
			result -= digits;
			count++;
		}

		counts[count] += 1;
		digits /= 10;
	}

	for (int k = 0; k <= 9; k++)
		printf("%d\n", counts[k]);

	return 0;
}