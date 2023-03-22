#include <iostream>
#include <cstring>
using namespace std;

int main()
{
	int t;
	int r;
	char s[21];

	cin >> t;
	for (int i = 0; i < t; i++)
	{
		cin >> r >> s;
		for (int j = 0; j < (int)strlen(s); j++)
		{
			for (int k = 0; k < r; k++)
			{
				cout << s[j];
			}
		}
		cout << endl;
	}
	return 0;
}