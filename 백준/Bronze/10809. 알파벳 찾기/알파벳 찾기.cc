#include <iostream>
#include <cstring>

using namespace std;

int main()
{
	char input[101];
	cin >> input;

	for (int i = 97; i <= 122; i++)
	{
		int pos = -1;
		for (int j = 0; j < strlen(input); j++)
		{
			if ((int)input[j] == i)
			{
				pos = j;
				break;
			}
		}
		cout << pos << " ";
	}

	return 0;
}