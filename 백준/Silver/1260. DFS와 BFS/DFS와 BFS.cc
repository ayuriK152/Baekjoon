#include <queue>
#include <iostream>
#include <sstream>
using namespace std;

vector<int> vertex[1000];
bool check[1000] = { false };
stringstream s;

void DFS(int start) {
	s << start + 1 << " ";
	check[start] = true;
	for (int i = 0; i < vertex[start].size(); i++) {
		if (!check[vertex[start][i]]) {
			DFS(vertex[start][i]);
		}
	}
}

void BFS(int start) {
	queue<int> q;
	q.push(start);
	check[start] = true;
	s << start + 1<< " ";
	while (q.size() > 0) {
		int current = q.front();
		q.pop();
		for (int i = 0; i < vertex[current].size(); i++) {
			if (!check[vertex[current][i]]) {
				q.push(vertex[current][i]);
				check[vertex[current][i]] = true;
				s << vertex[current][i] + 1 << " ";
			}
		}
	}
}

int main() {
	int n, m, v;
	int a, b;

	cin >> n >> m >> v;

	for (int i = 0; i < m; i++) {
		cin >> a >> b;
		vertex[a - 1].push_back(b - 1);
		vertex[b - 1].push_back(a - 1);
	}

	for (int i = 0; i < n; i++)
		sort(vertex[i].begin(), vertex[i].end());

	DFS(v - 1);
	fill_n(check, n, false);
	s << "\n";
	BFS(v - 1);

	cout << s.str();
	return 0;
}