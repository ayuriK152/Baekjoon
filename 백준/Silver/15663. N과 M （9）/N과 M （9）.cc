#include <bits/stdc++.h>
using namespace std;

map<int, int> nums;
int n, m;
vector<int> output;

void Recursive(int num, int count) {
	if (count == m) {
		for (int i : output)
			printf("%d ", i);
		printf("%d\n", num);
		return;
	}

	for (auto& numPair : nums) {
		if (numPair.second == 0)
			continue;
		numPair.second--;
		output.push_back(num);
		Recursive(numPair.first, count + 1);
		numPair.second++;
		output.erase(output.end() - 1);
	}
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		int a;
		cin >> a;
		if (nums.count(a) == 0)
			nums[a] = 0;
		nums[a]++;
	}

	for (auto& numPair : nums) {
		numPair.second--;
		Recursive(numPair.first, 1);
		numPair.second++;
	}

	return 0;
}