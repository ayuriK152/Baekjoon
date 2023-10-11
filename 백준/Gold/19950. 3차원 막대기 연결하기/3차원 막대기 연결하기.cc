#include <iostream>
#include <cmath>
using namespace std;

int main() {
	int x1, y1, z1, x2, y2, z2;
	cin >> x1 >> y1 >> z1 >> x2 >> y2 >> z2;
	double length = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2) + pow(z2 - z1, 2));
	int sticks[100];
	int n, sum = 0, max = 0;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> sticks[i];
		sum += sticks[i];
		if (sticks[i] > max)
			max = sticks[i];
	}

	string result;
	if (n == 1)
		result = sum == length ? "YES" : "NO";
	else {
		if (max < length)
			result = sum >= length ? "YES" : "NO";
		else if (max > length)
			result = max - (sum - max) <= length ? "YES" : "NO";
		else if (max == length)
			result = "YES";
	}

	cout << result;
	return 0;
}