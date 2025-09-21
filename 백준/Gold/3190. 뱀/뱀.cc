#include <bits/stdc++.h>
using namespace std;

int main() {
	int map[100][100];
	vector<pair<int, int>> bodies;
	vector<pair<int, char>> commands;
	int dir = 0;
	memset(map, 0, sizeof(int) * 100 * 100);
	map[0][0] = 1;
	bodies.push_back({ 0,0 });

	int n, k, l;
	cin >> n >> k;
	for (int i = 0; i < k; i++) {
		int x, y;
		cin >> x >> y;
		map[x - 1][y - 1] = 2;
	}
	cin >> l;
	for (int i = 0; i < l; i++) {
		int t;
		char c;
		cin >> t >> c;
		commands.push_back({ t, c });
	}

	int time = 0, commandIndex = 0;
	while (true) {
		time += 1;

		pair<int, int> headPos = bodies[0];
		switch (dir) {
		case 0:
			headPos.first++;
			break;
		case 1:
			headPos.second++;
			break;
		case 2:
			headPos.first--;
			break;
		case 3:
			headPos.second--;
			break;
		}

		if (headPos.first >= n || headPos.second >= n || headPos.first < 0 || headPos.second < 0)
			break;
		if (map[headPos.second][headPos.first] == 1)
			break;
		if (map[headPos.second][headPos.first] == 2) {
			bodies.push_back(bodies[bodies.size() - 1]);
			map[bodies[bodies.size() - 1].second][bodies[bodies.size() - 1].first] = 2;
		}

		for (int i = bodies.size() - 1; i >= 0; i--) {
			if (i == bodies.size() - 1)
				map[bodies[i].second][bodies[i].first]--;
			if (i > 0)
				bodies[i] = bodies[i - 1];
		}
		bodies[0] = headPos;
		map[bodies[0].second][bodies[0].first] = 1;

		if (commands.size() > commandIndex) {
			if (commands[commandIndex].first == time) {
				if (commands[commandIndex].second == 'L')
					dir = dir > 0 ? dir - 1 : 3;
				else
					dir = dir < 3 ? dir + 1 : 0;
				commandIndex++;
			}
		}
	}

	cout << time;

	return 0;
}