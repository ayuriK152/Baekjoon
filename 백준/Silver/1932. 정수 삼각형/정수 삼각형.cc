#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[500][500];
	int arr[500][500];

	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j <= i; j++) {
			cin >> arr[i][j];
		}
	}

	dp[0][0] = arr[0][0];
	int answer = dp[0][0];
	for (int i = 1; i < n; i++) {
		for (int j = 0; j <= i; j++) {
			if (j == 0)
				dp[i][j] = dp[i - 1][j] + arr[i][j];
			else if (j == i)
				dp[i][j] = dp[i - 1][j - 1] + arr[i][j];
			else
				dp[i][j] = max(dp[i - 1][j - 1], dp[i - 1][j]) + arr[i][j];

			if (i == n - 1)
				answer = max(answer, dp[i][j]);
		}
	}

	cout << answer;

	return 0;
}