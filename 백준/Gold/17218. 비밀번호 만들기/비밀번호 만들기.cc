#include <bits/stdc++.h>
using namespace std;

int main() {
	int dp[41][41];
	string dpAnswer[41][41];
	memset(dp, 0, sizeof(int) * 41 * 41);
	for (int i = 0; i < 41; i++)
		for (int j = 0; j < 41; j++)
			dpAnswer[i][j] = "";

	string a, b;
	cin >> a >> b;

	for (int i = 1; i <= a.size(); i++) {
		for (int j = 1; j <= b.size(); j++) {
			dp[i][j] = max(dp[i - 1][j], dp[i][j - 1]);
			if (dp[i - 1][j] > dp[i][j - 1]) {
				dp[i][j] = dp[i - 1][j];
				dpAnswer[i][j] = dpAnswer[i - 1][j];
			}
			else {
				dp[i][j] = dp[i][j - 1];
				dpAnswer[i][j] = dpAnswer[i][j - 1];
			}
			if (a[i - 1] == b[j - 1]) {
				if (dp[i - 1][j - 1] + 1 > dp[i][j - 1]) {
					dp[i][j] = dp[i - 1][j - 1] + 1;
					dpAnswer[i][j] = dpAnswer[i - 1][j - 1] += b[j - 1];
				}
				else {
					dp[i][j] = dp[i][j - 1];
					dpAnswer[i][j] = dpAnswer[i][j - 1];
				}
			}
		}
	}

	printf("%s", dpAnswer[a.size()][b.size()].c_str());

	return 0;
}