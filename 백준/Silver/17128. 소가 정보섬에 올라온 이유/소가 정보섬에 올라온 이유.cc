#include <iostream>
#include <string>
using namespace std;

int main() {
	int cows[200000];
	int sums[200000];
	int n, q;
	cin >> n >> q;
	for (int i = 0; i < n; i++)
		cin >> cows[i];
	int sum = 0;
	for (int i = 0; i < n; i++) {
		sums[i] = cows[i] * cows[(i + 1) % n] * cows[(i + 2) % n] * cows[(i + 3) % n];
		sum += sums[i];
	}

	string result = "";
	for (int i = 0; i < q; i++) {
		int a;
		cin >> a;
		for (int j = a - 4; j < a; j++) {
			int index = j < 0 ? n + j : j;
			sums[index] *= -1;
			sum += sums[index] * 2;
		}
		result.append(to_string(sum));
		result.append("\n");
	}
	cout << result;
	return 0;
}