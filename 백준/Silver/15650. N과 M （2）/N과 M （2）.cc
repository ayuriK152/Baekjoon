#include <bits/stdc++.h>
using namespace std;

vector<int> output;
int n, m;

void Recursive(int num, int count) {
	if (count == 0) {
		for (int i : output)
			cout << i << " ";
		cout << num << "\n";

		return;
	}

	output.push_back(num);
	for (int i = num + 1; i <= n; i++) {
		Recursive(i, count - 1);
	}
	output.erase(output.end() - 1);
}

int main() {
	cin >> n >> m;

	for (int i = 1; i <= n; i++)
		Recursive(i, m - 1);

	return 0;
}