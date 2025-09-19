#include <iostream>
#include <string>
#include <queue>
#include <cstring>
using namespace std;

int main() {
	int map[100][100];
	int n, m;
	cin >> n >> m;

	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		for (int j = 0; j < m; j++) {
			map[i][j] = input[j] - '0';
		}
	}


	// BFS
	queue<pair<int, int>> q;
	int visited[100][100];
	memset(visited, -1, sizeof(visited));
	visited[0][0] = 0;
	q.push({ 0, 0 });
	while (!q.empty()) {
		pair<int, int> cur = q.front();
		q.pop();
		int dist = visited[cur.second][cur.first] + 1;
		if (cur.first == m - 1 && cur.second == n - 1) {
			visited[cur.second][cur.first] = dist;
			break;
		}

		if (cur.first > 0) {
			if (map[cur.second][cur.first - 1] == 1 && visited[cur.second][cur.first - 1] == -1) {
				visited[cur.second][cur.first - 1] = dist;
				q.push({ cur.first - 1, cur.second });
			}
		}

		if (cur.first < m - 1) {
			if (map[cur.second][cur.first + 1] == 1 && visited[cur.second][cur.first + 1] == -1) {
				visited[cur.second][cur.first + 1] = dist;
				q.push({ cur.first + 1, cur.second });
			}
		}

		if (cur.second > 0) {
			if (map[cur.second - 1][cur.first] == 1 && visited[cur.second - 1][cur.first] == -1) {
				visited[cur.second - 1][cur.first] = dist;
				q.push({ cur.first, cur.second - 1 });
			}
		}

		if (cur.second < n - 1) {
			if (map[cur.second + 1][cur.first] == 1 && visited[cur.second + 1][cur.first] == -1) {
				visited[cur.second + 1][cur.first] = dist;
				q.push({ cur.first, cur.second + 1 });
			}
		}
	}

	cout << visited[n - 1][m - 1];

	return 0;
}