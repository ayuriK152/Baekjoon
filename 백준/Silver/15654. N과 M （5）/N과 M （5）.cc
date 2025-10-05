#include <bits/stdc++.h>
using namespace std;

int nums[8];
bool checks[8];
vector<int> output;
int n, m;

void Recursive(int idx, int count) {
	if (count == 0) {
		for (int i : output)
			cout << i << " ";
		cout << nums[idx] << "\n";

		return;
	}

	output.push_back(nums[idx]);
	checks[idx] = true;
	for (int i = 0; i < n; i++) {
		if (checks[i])
			continue;
		Recursive(i, count - 1);
	}
	output.erase(output.end() - 1);
	checks[idx] = false;
}

int main() {
	memset(checks, false, sizeof(bool) * 8);
	cin >> n >> m;

	for (int i = 0; i < n; i++)
		cin >> nums[i];

	sort(nums, nums + n);

	for (int i = 0; i < n; i++)
		Recursive(i, m - 1);

	return 0;
}