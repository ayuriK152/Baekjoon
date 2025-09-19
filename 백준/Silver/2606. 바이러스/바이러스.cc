#include <iostream>
#include <vector>
#include <map>
#include <queue>
using namespace std;

int main() {
	map<int, vector<int>> com;
	int n, m;
	cin >> n >> m;

	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		com[a].push_back(b);
		com[b].push_back(a);
	}

	int result = 0;
	map<int, bool> bfsCheck;
	queue<int> q;
	bfsCheck[1] = true;
	q.push(1);
	while (!q.empty()) {
		for (int i : com[q.front()]) {
			if (!bfsCheck[i]) {
				bfsCheck[i] = true;
				q.push(i);
				result++;
			}
		}
		q.pop();
	}

	cout << result;

	return 0;
}