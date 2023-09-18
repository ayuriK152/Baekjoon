#include <iostream>
#include <vector>
using namespace std;

class Pair {
public:
	int a, t;

public:
	Pair(int _a, int _t) {
		a = _a;
		t = _t;
	}
};

int main() {
	int n;
	cin >> n;
	vector<Pair> stack;
	int score = 0;
	for (; n > 0; n--) {
		int flag;
		cin >> flag;
		if (flag == 1) {
			int a, t;
			cin >> a;
			cin >> t;
			stack.push_back(Pair(a, t));
		}
		if (!stack.empty()) {
			stack.back().t--;
			if (stack.back().t == 0) {
				score += stack.back().a;
				stack.pop_back();
			}
		}
	}
	cout << score << endl;
	return 0;
}