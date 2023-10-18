#include <iostream>
using namespace std;


int FindRoot(int idx, int nodes[]) {
	if (nodes[idx] == idx)
		return idx;
	return nodes[idx] = FindRoot(nodes[idx], nodes);
}

int main() {
	int nodes[1000000];
	int n, m;
	cin >> n >> m;
	for (int i = 0; i < n; i++)
		nodes[i] = i;
	string result = "";
	for (int i = 0; i < m; i++) {
		int d, a, b;
		cin >> d >> a >> b;
		a = FindRoot(a - 1, nodes);
		b = FindRoot(b - 1, nodes);
		if (d == 0) {
			if (a > b)
				nodes[a] = b;
			else
				nodes[b] = a;
		}
		else {
			if (a == b)
				result.append("YES");
			else
				result.append("NO");
			result.append("\n");
		}
	}
	cout << result;
	return 0;
}