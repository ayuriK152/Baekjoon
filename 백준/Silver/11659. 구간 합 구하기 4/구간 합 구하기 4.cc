#include <iostream>
#include <string>
using namespace std;

int main() {
	string result;
	int arr[100000] = { 0 };
	int n, m;
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		cin >> arr[i];
		if (i > 0)
			arr[i] += arr[i - 1];
	}

	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		a -= 2; b -= 1;
		if (a < 0)
			result.append(to_string(arr[b]) + "\n");
		else
			result.append(to_string(arr[b] - arr[a]) + "\n");
	}

	result.erase(result.end() - 1);
	cout << result;

	return 0;
}