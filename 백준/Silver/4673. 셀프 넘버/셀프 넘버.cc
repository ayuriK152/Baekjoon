#include <iostream>

using namespace std;

int main()
{
	bool check[10001];

	for (int i = 0; i < 10001; i++)
	{
		check[i] = false;
	}

	for (int j = 1; j < 10001; j++)
	{
		int temp = j, temp2 = j;
		while (true)
		{
			temp += temp2 % 10;
			if (temp2 / 10 == 0)
				break;
			else
			{
				temp2 /= 10;
			}
		}
		if (temp < 10001)
			check[temp] = true;
	}

	for (int k = 1; k < 10001; k++)
	{
		if (!check[k])
			printf("%d\n", k);
	}

	return 0;
}