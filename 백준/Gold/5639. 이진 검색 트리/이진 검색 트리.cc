#include <bits/stdc++.h>
#include <unordered_map>
using namespace std;

int pre[10000];
int count = 0;

void Recursive(int curr, int end) {
	if (curr != end && curr != ::count - 1) {
		int leftIdx = curr + 1, rightIdx = end;
		for (int i = leftIdx; i < end; i++) {
			if (pre[curr] < pre[i]) {
				rightIdx = i;
				break;
			}
		}
		if (pre[curr] > pre[leftIdx])
			Recursive(leftIdx, rightIdx);
		if (rightIdx != end)
			Recursive(rightIdx, end);
	}

	cout << pre[curr] << "\n";
}

int main() {

	int input;

	while (cin >> input)
		pre[::count++] = input;

	Recursive(0, ::count);

	return 0;
}