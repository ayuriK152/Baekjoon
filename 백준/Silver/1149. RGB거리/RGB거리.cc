#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[3][1000];
	int arr[3][1000];

	int n;
	cin >> n;
	for (int i = 0; i < n; i++)
		cin >> arr[0][i] >> arr[1][i] >> arr[2][i];

	dp[0][0] = arr[0][0];
	dp[1][0] = arr[1][0];
	dp[2][0] = arr[2][0];

	for (int i = 1; i < n; i++) {
		dp[0][i] = arr[0][i] + min(dp[1][i - 1], dp[2][i - 1]);
		dp[1][i] = arr[1][i] + min(dp[0][i - 1], dp[2][i - 1]);
		dp[2][i] = arr[2][i] + min(dp[0][i - 1], dp[1][i - 1]);
	}

	cout << min(dp[0][n - 1], min(dp[1][n - 1], dp[2][n - 1]));

	return 0;
}