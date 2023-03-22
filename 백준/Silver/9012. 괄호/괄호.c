#include <stdio.h>

int main()
{
	char ps[51];
	int input;
	int count = 0;

	scanf("%d", &input);

	for (int i = 1; i <= input; i++)
	{
		scanf("%s", ps);
		for (int j = 0; j < strlen(ps); j++)
		{
			if (ps[j] == 40)
				count++;
			else if (ps[j] == 41)
				count--;
			if (count < 0)
				j = strlen(ps);
		}

		if (count == 0)
			printf("YES\n");
		else
			printf("NO\n");

		count = 0;
	}

	return 0;
}