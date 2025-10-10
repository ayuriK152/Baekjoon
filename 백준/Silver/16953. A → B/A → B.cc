#include <bits/stdc++.h>
using namespace std;

int main() {
	int a, b;
	cin >> a >> b;

	int count = 1;
	while (true) {
		if (b % 2 == 0)
			b /= 2;
		else if (b % 10 == 1)
			b /= 10;
		else {
			cout << -1;
			break;
		}
		count++;

		if (a == b) {
			cout << count;
			break;
		}
		else if (a > b) {
			cout << -1;
			break;
		}
	}

	return 0;
}