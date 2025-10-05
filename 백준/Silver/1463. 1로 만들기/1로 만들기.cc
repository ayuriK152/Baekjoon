#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[1000000];
	int n;
	cin >> n;

	dp[0] = 0;
	dp[1] = 1;
	dp[2] = 1;

	for (int i = 3; i < n; i++) {
		int cur = dp[i - 1];
		if ((i + 1) % 2 == 0)
			cur = min(cur, dp[(i + 1) / 2 - 1]);
		if ((i + 1) % 3 == 0)
			cur = min(cur, dp[(i + 1) / 3 - 1]);
		dp[i] = cur + 1;
	}

	printf("%d", dp[n - 1]);

	return 0;
}