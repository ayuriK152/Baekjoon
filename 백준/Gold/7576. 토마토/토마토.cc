#include <bits/stdc++.h>
using namespace std;

int main() {
	int total = 0, time = 0;
	bool check[1000][1000];
	queue<pair<int, int>> q;
	memset(check, false, sizeof(false) * 1000 * 1000);

	int n, m;
	cin >> n >> m;
	for (int i = 0; i < m; i++) {
		for (int j = 0; j < n; j++) {
			int value;
			cin >> value;
			if (value == -1)
				check[i][j] = true;
			if (value >= 0)
				total++;
			if (value == 1) {
				q.push({ j, i });
				check[i][j] = true;
			}
		}
	}

	int currCount = q.size();
	while (!q.empty()) {
		pair<int, int> curr = q.front();
		q.pop();
		total--;

		if (curr.first > 0) {
			if (!check[curr.second][curr.first - 1]) {
				check[curr.second][curr.first - 1] = true;
				q.push({ curr.first - 1, curr.second });
			}
		}
		if (curr.first < n - 1) {
			if (!check[curr.second][curr.first + 1]) {
				check[curr.second][curr.first + 1] = true;
				q.push({ curr.first + 1, curr.second });
			}
		}
		if (curr.second > 0) {
			if (!check[curr.second - 1][curr.first]) {
				check[curr.second - 1][curr.first] = true;
				q.push({ curr.first, curr.second - 1 });
			}
		}
		if (curr.second < m - 1) {
			if (!check[curr.second + 1][curr.first]) {
				check[curr.second + 1][curr.first] = true;
				q.push({ curr.first, curr.second + 1 });
			}
		}

		currCount--;
		if (currCount == 0 && q.size() > 0) {
			currCount = q.size();
			time++;
		}
	}

	if (total != 0)
		cout << -1;
	else
		cout << time;

	return 0;
}