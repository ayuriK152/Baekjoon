#include <stdio.h>

int main()
{
	char word[1000001];
	char mostAlp;
	int alp[26] = { 0, };
	int len, mostCount, sameCount = 0;

	scanf("%s", word);
	len = strlen(word);

	for (int i = 0; i < len; i++)
	{
		if (word[i] > 90)
			word[i] -= 32;

		alp[word[i] - 65]++;
	}

	for (int j = 0; j <= 25; j++)
	{
		if (j == 0)
		{
			mostAlp = j + 65;
			mostCount = alp[j];
		}

		if (alp[j] > mostCount)
		{
			mostAlp = j + 65;
			mostCount = alp[j];
			sameCount = 0;
		}

		else if (alp[j] == mostCount && j != 0)
			sameCount++;
	}

	if (sameCount == 0)
		printf("%c", mostAlp);
	else
		printf("?");

	return 0;
}