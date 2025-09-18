#include <iostream>
using namespace std;

int values[1000][3];
int dp[1000][3];
int n;

int main() {
	cin >> n;
	for (int i = 0; i < n; i++) {
		int r, g, b;
		cin >> r >> g >> b;
		values[i][0] = r;
		values[i][1] = g;
		values[i][2] = b;
	}

	dp[0][0] = values[0][0];
	dp[0][1] = values[0][1];
	dp[0][2] = values[0][2];

	for (int i = 1; i < n; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			dp[i][j] = min(dp[i - 1][(j + 1) % 3], dp[i - 1][(j + 2) % 3]) + values[i][j];
		}
	}

	cout << min(min(dp[n - 1][0], dp[n - 1][1]), dp[n - 1][2]);

	return 0;
}