#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main() {
	cout << setprecision(16);
	double x1, y1, x2, y2, p, q, r;
	cin >> x1 >> y1 >> x2 >> y2 >> p >> q >> r;
	if (y1 > y2) {
		int temp = x1;
		x1 = x2;
		x2 = temp;
		temp = y1;
		y1 = y2;
		y2 = temp;
	}
	double lowFlag = p * x2 + q * y1, highFlag = p * x1 + q * y2;
	double inc = (y2 - y1) / (x2 - x1);
	double result = 0;
	if ((inc > 0 && -p / q < 0) || (inc < 0 && -p / q > 0) || x1 == x2 || y1 == y2 || lowFlag >= r || highFlag <= r)
		result = abs(x2 - x1) + abs(y2 - y1);
	else {
		double x3 = x1, y3 = y1, x4 = x2, y4 = y2;
		double startFlag = p * x1 + q * y1, destFlag = p * x2 + q * y2;
		if (startFlag <= r && destFlag >= r) {
			x3 = x1, y3 = -x1 * (p / q) + r / q, x4 = x2, y4 = -x2 * (p / q) + r / q;
			result = abs(y3 - y1) + abs(y4 - y2);
		}
		else if (startFlag >= r && destFlag <= r) {
			x3 = -y1 * (q / p) + r / p, y3 = y1, x4 = -y2 * (q / p) + r / p, y4 = y2;
			result = abs(x3 - x1) + abs(x4 - x2);
		}
		else if (startFlag <= r && destFlag <= r) {
			x3 = x1, y3 = -x1 * (p / q) + r / q, x4 = -y2 * (q / p) + r / p, y4 = y2;
			result = abs(y3 - y1) + abs(x4 - x2);
		}
		else if (startFlag >= r && destFlag >= r) {
			x3 = -y1 * (q / p) + r / p, y3 = y1, x4 = x2, y4 = -x2 * (p / q) + r / q;
			result = abs(x3 - x1) + abs(y4 - y2);
		}
		result += sqrt(pow(x4 - x3, 2) + pow(y4 - y3, 2));
	}
	cout << result;
	return 0;
}