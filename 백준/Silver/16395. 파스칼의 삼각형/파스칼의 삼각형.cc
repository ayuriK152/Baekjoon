#include <iostream>
#include <vector>
using namespace std;

int main() {
	vector<long> paskal[30];
	paskal[0].push_back(1);
	paskal[1].push_back(1);
	paskal[1].push_back(1);
	for (int i = 2; i < 30; i++) {
		paskal[i].push_back(1);
		for (int j = 1; j < i; j++)
			paskal[i].push_back(paskal[i - 1][j - 1] + paskal[i - 1][j]);
		paskal[i].push_back(1);
	}

	int n, k;
	cin >> n >> k;
	cout << paskal[n - 1][k - 1];
	return 0;
}