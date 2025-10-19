#include <bits/stdc++.h>
using namespace std;

int main() {
	for (int i = 0; i < 3; i++) {
		int t;
		cin >> t;

		vector<long long> pos;
		vector<long long> neg;
		for (; t > 0; t--) {
			long long a;
			cin >> a;
			if (a > 0)
				pos.push_back(a);
			else if (a < 0)
				neg.push_back(a);
		}

		while (pos.size() > 0 && neg.size() > 0) {
			long long calc = pos[0] + neg[0];
			if (calc > 0) {
				pos[0] += neg[0];
				neg.erase(neg.begin());
			}
			else if (calc < 0) {
				neg[0] += pos[0];
				pos.erase(pos.begin());
			}
			else {
				pos.erase(pos.begin());
				neg.erase(neg.begin());
			}
		}

		if (pos.size() > 0)
			cout << "+\n";
		else if (neg.size() > 0)
			cout << "-\n";
		else
			cout << "0\n";
	}

	return 0;
}