#include <stdio.h>
#include <stdbool.h>

int main()
{
	int a;

	scanf("%d", &a);

	solt(a);

	return 0;
}

int solt(int count)
{
	int num[1000], input, temp;
	bool isCounted = false;

	for (int i = 0; i <= count-1; i++)
	{
		scanf("%d", &input);
		num[i] = input;
	}

	while (1)
	{

		for (int j = 0; j <= count - 1; j++)
		{
			for (int k = j; k <= count - 1; k++)
			{
				if (j != k && num[j] > num[k])
				{
					temp = num[j];
					num[j] = num[k];
					num[k] = temp;
					isCounted = true;
				}
			}
		}

		if (isCounted == false)
		{
			for (int l = 0; l <= count - 1; l++)
			{
				printf("%d\n", num[l]);
			}
			break;
		}

		isCounted = false;
	}
}