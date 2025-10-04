#include <bits/stdc++.h>
using namespace std;

int main() {
	int arr[1000];
	int n;
	cin >> n;
	
	for (int i = 0; i < n; i++)
		cin >> arr[i];

	sort(arr, arr + n);

	for (int i = 1; i < n; i++)
		arr[i] = arr[i - 1] + arr[i];
	int answer = 0;
	for (int i = 0; i < n; i++)
		answer += arr[i];

	printf("%d", answer);

	return 0;
}