#include <iostream>
#include <cstring>
#include <queue>
using namespace std;

int main() {
	int map[1000][1000];
	int result[1000][1000] = { -1 };
	memset(result, -1, sizeof(result));
	pair<int, int> goal;
	int n, m;

	cin >> n >> m;
	for (int y = 0; y < n; y++) {
		for (int x = 0; x < m; x++) {
			cin >> map[y][x];
			if (map[y][x] == 2)
				goal = { x, y };
			if (map[y][x] == 0)
				result[y][x] = 0;
		}
	}

	queue<pair<int, int>> q;
	q.push(goal);
	result[goal.second][goal.first] = 0;
	while (!q.empty()) {
		pair<int, int> current = q.front();
		q.pop();

		if (map[current.second][current.first] == 0) {
			continue;
		}

		if (current.first > 0) {
			if (result[current.second][current.first - 1] == -1) {
				result[current.second][current.first - 1] = result[current.second][current.first] + 1;
				q.push({ current.first - 1, current.second });
			}
		}
		if (current.first < m - 1) {
			if (result[current.second][current.first + 1] == -1) {
				result[current.second][current.first + 1] = result[current.second][current.first] + 1;
				q.push({ current.first + 1, current.second });
			}
		}
		if (current.second > 0) {
			if (result[current.second - 1][current.first] == -1) {
				result[current.second - 1][current.first] = result[current.second][current.first] + 1;
				q.push({ current.first, current.second - 1 });
			}
		}
		if (current.second < n - 1) {
			if (result[current.second + 1][current.first] == -1) {
				result[current.second + 1][current.first] = result[current.second][current.first] + 1;
				q.push({ current.first, current.second + 1 });
			}
		}
	}

	for (int y = 0; y < n; y++) {
		for (int x = 0; x < m; x++) {
			cout << result[y][x];
			if (x != m - 1)
				cout << " ";
		}
		if (y != n - 1)
			cout << "\n";
	}

	return 0;
}