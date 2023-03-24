#include <iostream>

using namespace std;

int main()
{
	int n;
	char input[101];
	int result = 0;
	cin >> n;
	cin >> input;

	for (int i = 0; i < n; i++)
	{
		result += (int)input[i] - 48;
	}

	cout << result;
	return 0;
}