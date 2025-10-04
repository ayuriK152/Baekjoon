#include <bits/stdc++.h>
using namespace std;

int main() {
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	bool sets[20];
	memset(sets, false, sizeof(bool) * 20);

	int m;
	cin >> m;
	while (true) {
		string cmd;
		cin >> cmd;

		if (cmd == "all") memset(sets, true, sizeof(bool) * 20);
		else if (cmd == "empty") memset(sets, false, sizeof(bool) * 20);
		else {
			int x;
			cin >> x;
			
			if (cmd == "add") sets[x - 1] = true;
			else if (cmd == "remove") sets[x - 1] = false;
			else if (cmd == "check") printf(sets[x - 1] ? "1\n" : "0\n");
			else if (cmd == "toggle") sets[x - 1] = !sets[x - 1];
		}

		m--;
		if (m == 0) break;
	}

	return 0;
}