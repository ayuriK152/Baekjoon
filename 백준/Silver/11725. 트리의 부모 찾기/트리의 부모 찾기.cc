#include <bits/stdc++.h>
using namespace std;

int main() {
	vector<int> nodes[1000000];
	int parent[1000000];
	memset(parent, 0, sizeof(int) * 1000000);
	int n;
	cin >> n;
	for (int i = 0; i < n - 1; i++) {
		int a, b;
		cin >> a >> b;
		nodes[a - 1].push_back(b - 1);
		nodes[b - 1].push_back(a - 1);
	}

	queue<int> q;
	q.push(0);
	while (!q.empty()) {
		int curr = q.front();
		q.pop();
		for (int c : nodes[curr]) {
			if (c != 0 && parent[c] != 0)
				continue;
			q.push(c);
			parent[c] = curr + 1;
		}
	}

	for (int i = 1; i < n; i++)
		printf("%d\n", parent[i]);

	return 0;
}