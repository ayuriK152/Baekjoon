#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[301];
	int stair[301];
	int n;
	cin >> n;

	for (int i = 1; i <= n; i++)
		cin >> stair[i];

	dp[0] = 0;
	dp[1] = stair[1];
	dp[2] = stair[1] + stair[2];

	for (int i = 3; i <= n; i++)
		dp[i] = max(stair[i - 1] + dp[i - 3], dp[i - 2]) + stair[i];

	printf("%d", dp[n]);

	return 0;
}