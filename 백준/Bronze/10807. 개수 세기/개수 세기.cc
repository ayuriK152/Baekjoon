#include <bits/stdc++.h>
using namespace std;

int main() {
	int arr[100];
	int n;
	cin >> n;
	
	for (int i = 0; i < n; i++)
		cin >> arr[i];

	int v, count = 0;
	cin >> v;
	for (int i = 0; i < n; i++)
		count = arr[i] == v ? count + 1 : count;

	printf("%d", count);

	return 0;
}