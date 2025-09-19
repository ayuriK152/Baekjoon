#include <iostream>
#include <string>
#include <vector>
using namespace std;

int n, m;
vector<int> result;
string resultStr;

void Recursive(int num, int len) {
	if (len == m - 1)
	{
		for (int i = 0; i < result.size(); i++)
			resultStr.append(to_string(result[i]) + " ");
		resultStr.append(to_string(num + 1) + "\n");
		return;
	}
	for (int i = num; i < n; i++)
	{
		result.push_back(num + 1);
		Recursive(i, len + 1);
		result.pop_back();
	}
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++)
	{
		Recursive(i, 0);
	}

	cout << resultStr;

	return 0;
}