#include <bits/stdc++.h>
using namespace std;

int main() {
	pair<long long int, long long int> dots[1500];
	int n;
	cin >> n;

	for (int i = 0; i < n; i++)
		cin >> dots[i].first >> dots[i].second;

	int count = 0;
	for (int i = 0; i < n - 2; i++) {
		for (int j = i + 1; j < n - 1; j++) {
			for (int k = j + 1; k < n; k++) {
				long long int lens[3];
				lens[0] = (dots[j].first - dots[i].first) * (dots[j].first - dots[i].first) + (dots[j].second - dots[i].second) * (dots[j].second - dots[i].second);
				lens[1] = (dots[k].first - dots[i].first) * (dots[k].first - dots[i].first) + (dots[k].second - dots[i].second) * (dots[k].second - dots[i].second);
				lens[2] = (dots[j].first - dots[k].first) * (dots[j].first - dots[k].first) + (dots[j].second - dots[k].second) * (dots[j].second - dots[k].second);
				if (lens[0] + lens[1] == lens[2] || lens[1] + lens[2] == lens[0] || lens[0] + lens[2] == lens[1])
					count++;
			}
		}
	}

	cout << count;

	return 0;
}