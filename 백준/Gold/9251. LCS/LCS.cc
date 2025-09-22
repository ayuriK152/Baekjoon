#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[1001][1001];
	memset(dp, 0, sizeof(int) * 1001 * 1001);

	string a, b;
	cin >> a >> b;

	for (int n = 1; n <= a.size(); n++) {
		for (int m = 1; m <= b.size(); m++) {
			dp[n][m] = max(dp[n - 1][m], dp[n][m - 1]);

			if (a[n - 1] == b[m - 1])
				dp[n][m] = dp[n - 1][m - 1] + 1;
		}
	}

	cout << dp[a.size()][b.size()];

	return 0;
}