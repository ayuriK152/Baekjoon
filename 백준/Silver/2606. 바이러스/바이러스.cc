#include <bits/stdc++.h>
using namespace std;

int main() {
	bool check[100];
	memset(check, false, sizeof(bool) * 100);
	vector<int> graph[100];

	int n, m;
	cin >> n >> m;

	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		graph[a - 1].push_back(b - 1);
		graph[b - 1].push_back(a - 1);
	}

	queue<int> q;
	q.push(0);
	check[0] = true;
	int count = 0;
	while (!q.empty()) {
		int curr = q.front();
		q.pop();

		for (int c : graph[curr]) {
			if (!check[c]) {
				check[c] = true;
				q.push(c);
				count++;
			}
		}
	}

	printf("%d", count);

	return 0;
}