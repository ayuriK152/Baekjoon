#include <stdio.h>
#include <math.h>

int turret();

int main()
{
	int input;

	scanf("%d", &input);
	for (int i = 0; i < input; i++)
	{
		printf("%d\n", turret());
	}

	return 0;
}

int turret()
{
	int info[6];
	int len[3];
	int longest, other[2];

	for (int i = 0; i < 6; i++)
	{
		scanf("%d", &info[i]);
		getchar();
	}
	len[0] = pow(info[0] - info[3], 2) + pow(info[1] - info[4], 2);
	len[1] = pow(info[2], 2);
	len[2] = pow(info[5], 2);

	if (len[0] >= len[1] && len[0] >= len[2])
	{
		longest = len[0];
		other[0] = len[1];
		other[1] = len[2];
	}
	else if (len[1] >= len[0] && len[1] >= len[2])
	{
		longest = len[1];
		other[0] = len[0];
		other[1] = len[2];
	}
	else if (len[2] >= len[0] && len[2] >= len[1])
	{
		longest = len[2];
		other[0] = len[0];
		other[1] = len[1];
	}

	if (sqrt(longest) < sqrt(other[0]) + sqrt(other[1]))
		return 2;
	else if (info[0] == info[3] && info[1] == info[4] && info[2] == info[5])
		return -1;
	else if (sqrt(longest) == sqrt(other[0]) + sqrt(other[1]))
		return 1;
	else
		return 0;
}