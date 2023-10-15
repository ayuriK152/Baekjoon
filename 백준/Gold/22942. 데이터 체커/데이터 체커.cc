#include <iostream>
#include <algorithm>
#include <vector>
#include <stack>
using namespace std;

int main() {
	pair<int, int> circles[200000];
	vector<int> points;
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> circles[i].first >> circles[i].second;
		points.push_back(circles[i].first - circles[i].second);
		points.push_back(circles[i].first + circles[i].second);
	}
	sort(points.begin(), points.end());
	sort(circles, circles + n, [](const pair<int, int>& a, const pair<int, int>& b) { return a.first - a.second < b.first - b.second; });
	int circleIdx = 0, prev = points[0] - 1;
	stack<pair<int, int>> stack;
	string result = "YES";
	for (int i = 0; i < points.size(); i++) {
		if (points[i] == prev) {
			result = "NO";
			break;
		}
		prev = points[i];
		if (circles[circleIdx].first - circles[circleIdx].second == points[i])
			stack.push(circles[circleIdx++]);
		else if (stack.top().first + stack.top().second == points[i])
			stack.pop();
		else {
			result = "NO";
			break;
		}
	}
	cout << result;
	return 0;
}