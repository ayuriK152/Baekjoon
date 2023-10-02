#include <iostream>
#include <algorithm>
using namespace std;

long height[300000];
long cost[300000];

int main() {
	int n, k;
	cin >> n >> k;
	for (int i = 0; i < n; i++)
		cin >> height[i];
	for (int i = 1; i < n; i++)
		cost[i] = height[i] - height[i - 1];
	sort(cost, cost + n);
	long result = 0;
	for (int i = 0; i <= n - k; i++)
		result += cost[i];
	cout << result;
	return 0;
}