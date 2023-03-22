#include <stdio.h>
#include <stdbool.h>

bool check_hansu(int num);

int main()
{
	int input, count = 0;

	scanf("%d", &input);

	for (int i = 1; i <= input; i++)
	{
		if (check_hansu(i))
			count++;
	}

	printf("%d", count);

	return 0;
}

bool check_hansu(int num)
{
	int digits, fst = -1, sec, diff = 10;
	bool isHansu = true;

	for (int i = 1; num / i >= 1;)
	{
		digits = i;
		i *= 10;
	}

	for (int j = 0; digits >= 1; j++)
	{
		int count = 0;

		while (num - digits >= 0)
		{
			num -= digits;
			count++;
		}

		sec = count;

		if (fst != -1 && diff == 10)
			diff = fst - sec;

		if (fst != -1 && diff != 10)
			if (fst - sec != diff)
				isHansu = false;

		fst = sec;
		digits /= 10;
	}

	return isHansu;
}