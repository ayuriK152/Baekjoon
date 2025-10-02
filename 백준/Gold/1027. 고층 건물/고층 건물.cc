#include <bits/stdc++.h>
using namespace std;

long CCW(int x1, int y1, int x2, int y2, int x3, int y3) {
	return (long)(x2 - x1) * (long)(y3 - y1) - (long)(x3 - x1) * (long)(y2 - y1);
}

int main() {
	int answer = 0;
	int arr[50];

	int n;
	cin >> n;

	for (int i = 0; i < n; i++)
		cin >> arr[i];

	if (n <= 2) {
		if (n == 2)
			answer = 1;
	}
	else {
		for (int i = 0; i < n; i++) {
			int count = i == 0 || i == n - 1 ? 1 : 2;

			int last = i - 1;
			for (int l = i - 2; l >= 0; l--) {
				long ccwVal = CCW(i, arr[i], last, arr[last], l, arr[l]);
				if (ccwVal < 0)
					count++;
				if (ccwVal <= 0)
					last = l;
			}

			last = i + 1;
			for (int r = i + 2; r < n; r++) {

				long ccwVal = CCW(i, arr[i], last, arr[last], r, arr[r]);
				if (ccwVal > 0)
					count++;
				if (ccwVal >= 0)
					last = r;
			}

			answer = answer < count ? count : answer;
		}
	}

	cout << answer;

	return 0;
}