#include <bits/stdc++.h>
using namespace std;

int main() {
	int fact[11];
	fact[0] = 1;
	fact[1] = 1;
	for (int i = 2; i <= 10; i++)
		fact[i] = fact[i - 1] * i;

	int t;
	cin >> t;
	for (int i = 0; i < t; i++) {
		int n;
		cin >> n;

		int count = 0;
		int numCount[3] = { n, 0, 0 };
		while (true) {
			int temp = fact[numCount[0] + numCount[1] + numCount[2]];
			temp /= fact[numCount[0]];
			temp /= fact[numCount[1]];
			temp /= fact[numCount[2]];
			count += temp;

			if (numCount[0] >= 2) {
				numCount[0] -= 2;
				numCount[1] += 1;
			}
			else if (numCount[0] < 2) {
				numCount[1] = 0;
				numCount[2] += 1;
				numCount[0] = n - numCount[2] * 3;
			}
			if (numCount[0] < 0)
				break;
		}

		printf("%d\n", count);
	}

	return 0;
}