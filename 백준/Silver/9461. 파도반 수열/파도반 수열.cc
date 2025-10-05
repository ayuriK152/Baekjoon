#include <bits/stdc++.h>
using namespace std;

int main() {
	long long int dp[100] = { 1, 1, 1, 2, 2, };
	for (int i = 5; i < 100; i++)
		dp[i] = dp[i - 1] + dp[i - 5];

	int t, n;
	cin >> t;
	for (int i = 0; i < t; i++) {
		cin >> n;
		printf("%lld\n", dp[n - 1]);
	}

	return 0;
}