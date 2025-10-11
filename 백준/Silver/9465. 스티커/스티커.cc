#include <bits/stdc++.h>
using namespace std;

int main() {
	int t;
	cin >> t;
	for (; t > 0; t--) {
		int dp[2][100000];
		int arr[2][100000];

		int n;
		cin >> n;

		for (int i = 0; i < n; i++)
			cin >> arr[0][i];
		for (int i = 0; i < n; i++)
			cin >> arr[1][i];

		if (n == 1)
			cout << max(arr[0][0], arr[1][0]) << "\n";
		else {
			dp[0][0] = arr[0][0];
			dp[1][0] = arr[1][0];
			dp[0][1] = dp[1][0] + arr[0][1];
			dp[1][1] = dp[0][0] + arr[1][1];

			for (int i = 2; i < n; i++) {
				dp[0][i] = max(dp[1][i - 1], dp[1][i - 2]) + arr[0][i];
				dp[1][i] = max(dp[0][i - 1], dp[0][i - 2]) + arr[1][i];
			}

			cout << max(dp[0][n - 1], dp[1][n - 1]) << "\n";
		}
	}

	return 0;
}