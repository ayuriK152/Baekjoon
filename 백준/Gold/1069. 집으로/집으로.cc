#include <bits/stdc++.h>
using namespace std;

int main() {
	double answer = 0;

	int x, y, d, t;
	cin >> x >> y >> d >> t;

	double remain = sqrt(x * x + y * y);
	if ((double)d / t < 1.0)
		answer = remain;
	else {
		while (true) {
			if (abs(remain) < d * 2) {
				answer += min(min((double)t * 2, abs(remain)), t + abs(remain - d));
				break;
			}
			remain -= d;
			answer += t;
		}
	}

	cout.precision(12);
	cout << fixed << answer;

	return 0;
}