#include <iostream>
#include <string>
#include <vector>
using namespace std;

bool flag[8];
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
	for (int i = 0; i < n; i++)
	{
		if (flag[i])
			continue;
		flag[i] = true;
		result.push_back(num + 1);
		Recursive(i, len + 1);
		flag[i] = false;
		result.pop_back();
	}
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++)
	{
		flag[i] = true;
		Recursive(i, 0);
		flag[i] = false;
	}

	cout << resultStr;

	return 0;
}