#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
using namespace std;

vector<int> nums;
vector<int> sequence;
string result;
bool visited[10];
int n, m;

void Recursive(int len) {
	if (len == m - 1) {
		for (int i = 0; i < sequence.size(); i++) {
			result.append(to_string(sequence[i]));
			if (i != sequence.size() - 1)
				result.append(" ");
		}
		result.append("\n");
	}

	for (int i = 0; i < n; i++) {
		if (!visited[i]) {
			visited[i] = true;
			sequence.push_back(nums[i]);
			Recursive(len + 1);
			sequence.pop_back();
			visited[i] = false;
		}
	}
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		int a;
		cin >> a;
		nums.push_back(a);
	}
	sort(nums.begin(), nums.end());

	for (int i = 0; i < n; i++) {
		visited[i] = true;
		sequence.push_back(nums[i]);
		Recursive(0);
		sequence.pop_back();
		visited[i] = false;
	}

	result.erase(result.end() - 1);

	cout << result;

	return 0;
}