#include <iostream>
#include <vector>
#include <stack>
#include <queue>
#include <map>
#include <algorithm>
#include <string>
using namespace std;

map<int, vector<int>> graph;
map<int, bool> visited;

int main() {
	string result;
	int n, m, v;
	cin >> n >> m >> v;
	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		graph[a].push_back(b);
		graph[b].push_back(a);
	}

	for (auto& node : graph)
		sort(node.second.begin(), node.second.end());
	for (auto& b : visited)
		b.second = false;

	// DFS
	stack<int> s;
	s.push(v);
	while (!s.empty()) {
		int cur = s.top();
		s.pop();
		if (visited[cur])
			continue;

		visited[cur] = true;
		for (int i = graph[cur].size() - 1; i >= 0; i--) {
			if (!visited[graph[cur][i]]) {
				s.push(graph[cur][i]);
			}
		}

		result.append(to_string(cur));
		if (!s.empty())
			result.append(" ");
	}

	result.append("\n");
	for (auto& b : visited)
		b.second = false;
	visited[v] = true;

	// BFS
	queue<int> q;
	q.push(v);
	while (!q.empty()) {
		int cur = q.front();
		q.pop();
		for (int node : graph[cur]) {
			if (!visited[node]) {
				q.push(node);
				visited[node] = true;
			}
		}

		result.append(to_string(cur));
		if (!q.empty())
			result.append(" ");
	}

	cout << result;

	return 0;
}