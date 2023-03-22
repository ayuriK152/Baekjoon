#include <stdio.h>

int main()
{
	int hour, min;

	scanf("%d %d", &hour, &min);

	if (min < 45)
	{
		if (hour == 0)
			hour = 23;

		else
			hour -= 1;

		min += 15;
	}

	else
		min -= 45;

	printf("%d %d", hour, min);
	
	return 0;
}