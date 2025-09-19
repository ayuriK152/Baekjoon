#include <iostream>
#include <string>
using namespace std;

int main() {
	int arr[1024][1024];
	int dp[1024][1024];
	int n, m;

	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			cin >> arr[i][j];
			dp[i][j] = arr[i][j];
			if (j > 0)
				dp[i][j] += dp[i][j - 1];
		}
		if (i > 0) {
			for (int j = 0; j < n; j++) {
				dp[i][j] += dp[i - 1][j];
			}
		}
	}

	string resultStr;
	for (int i = 0; i < m; i++) {
		int x1, y1, x2, y2;
		cin >> x1 >> y1 >> x2 >> y2;

		int result = dp[x2 - 1][y2 - 1];
		if (x1 > 1)
			result -= dp[x1 - 2][y2 - 1];
		if (y1 > 1)
			result -= dp[x2 - 1][y1 - 2];
		if (x1 > 1 && y1 > 1)
			result += dp[x1 - 2][y1 - 2];

		resultStr.append(to_string(result));
		if (i != m - 1)
			resultStr.append("\n");
	}

	cout << resultStr;

	return 0;
}