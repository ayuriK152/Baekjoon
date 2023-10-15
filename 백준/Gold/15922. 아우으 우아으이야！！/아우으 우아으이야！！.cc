#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
using namespace std;

int main() {
	int n;
	cin >> n;
	vector<pair<int, bool>> points;
	for (int i = 0; i < n; i++) {
		int x, y;
		cin >> x >> y;
		points.push_back({ x, true });
		points.push_back({ y, false });
	}
	sort(points.begin(), points.end(), [](const pair<int, bool>& a, const pair<int, bool>& b) { return a.first < b.first; });

	int count = 0, startIdx = 0, total = 0;
	for (int i = 0; i < points.size(); i++) {
		if (count == 0 && points[i].second)
			startIdx = points[i].first;
		count = points[i].second ? count + 1 : count - 1;
		if (count == 0 && !points[i].second)
			total += abs(points[i].first - startIdx);
	}

	cout << total;
	return 0;
}