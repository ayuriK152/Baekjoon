#include <bits/stdc++.h>
#include <unordered_map>
using namespace std;

int main() {
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	string answer;

	unordered_map<int, vector<pair<int, int>>> edges;
	int minDist[20000];
	memset(minDist, -1, sizeof(int) * 20000);

	int v, e, s;
	cin >> v >> e >> s;
	for (int i = 0; i < e; i++) {
		int u, v, w;
		cin >> u >> v >> w;
		edges[u].push_back({ w, v });
	}

	minDist[s - 1] = 0;
	priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> q;
	for (auto& path : edges[s])
		q.push(path);
	while (!q.empty()) {
		pair<int, int> curr = q.top();
		q.pop();
		if (minDist[curr.second - 1] > curr.first || minDist[curr.second - 1] == -1) {
			minDist[curr.second - 1] = curr.first;
			for (auto& path : edges[curr.second]) {
				if (minDist[curr.second - 1] != -1)
					q.push({ minDist[curr.second - 1] + path.first, path.second });
			}
		}
	}

	for (int i = 0; i < v; i++) {
		if (minDist[i] >= 0)
			answer.append(to_string(minDist[i]) + "\n");
			// cout << minDist[i] << "\n";
		else
			answer.append("INF\n");
			// cout << "INF\n";
	}

	cout << answer;

	return 0;
}