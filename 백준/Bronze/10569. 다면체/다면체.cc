#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector<int> result;
	int t;
	cin >> t;
	for (; t > 0; t--)
	{
		int v, e;
		cin >> v >> e;
		result.push_back(e + 2 - v);
	}
	for (int i = 0; i < result.size(); i++)
	{
		cout << result[i] << endl;
	}

	return 0;
}