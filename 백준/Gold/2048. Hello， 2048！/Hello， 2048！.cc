#include <iostream>
#include <cmath>
#include <string>
using namespace std;

int main() {
	int t;
	cin >> t;
	string result;
	for (; t > 0; t--) {
		long l, r;
		cin >> l >> r;
		if (r > 3)
			result.append(to_string(r));
		else {
			int goal = 0;
			for (int i = l; i <= r; i++) {
				goal *= 10;
				goal += pow(2, i);
			}
			int count = 0;
			while (goal % 2 == 0) {
				goal /= 2;
				count++;
			}
			result.append(to_string(count));
		}
		result.append("\n");
	}
	cout << result;
	return 0;
}