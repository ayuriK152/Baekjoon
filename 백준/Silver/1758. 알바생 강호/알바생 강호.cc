#include <iostream>
#include <algorithm>
using namespace std;

bool desc(int a, int b) {
	return a > b;
}

int main() {
	int n;
	cin >> n;

	int tips[100000];
	for (int i = 0; i < n; i++) {
		cin >> tips[i];
	}
	
	sort(tips, tips + n, desc);
	long total = 0;
	for (int i = 0; i < n; i++) {
		total += tips[i] - i > 0 ? tips[i] - i : 0;
	}

	cout << total;

	return 0;
}