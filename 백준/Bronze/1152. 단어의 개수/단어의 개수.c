#include <stdio.h>
#include <string.h>
#include <stdbool.h>

int main()
{
	char str[1000001];
	char* ptr = &str;

	int counter = 0;
	int len;

	bool isCounted = false;

	gets(str, 1000001);
	len = strlen(str);

	for (int i = 0; i <= len-1; i++)
	{
		if (isCounted == false)
		{
			if (str[i] != ' ')
			{
				counter++;
				isCounted = true;
			}
		}

		else
			if (str[i] == ' ')
				isCounted = false;


	}

	printf("%d", counter);

	return 0;
}