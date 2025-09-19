#include <iostream>
using namespace std;

int main() {
	int arr[1000];
	int dp[1000];
	int result;

	int n;
	cin >> n;
	for (int i = 0; i < n; i++)
		cin >> arr[i];

	dp[0] = arr[0];
	result = dp[0];
	for (int i = 1; i < n; i++) {
		dp[i] = arr[i];
		for (int j = 0; j < i; j++) {
			if (arr[i] > arr[j])
				dp[i] = max(dp[i], dp[j] + arr[i]);
		}
		result = max(result, dp[i]);
	}

	cout << result;

	return 0;
}