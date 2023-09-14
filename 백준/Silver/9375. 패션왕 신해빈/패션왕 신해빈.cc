#include <iostream>
#include <map>
using namespace std;

int main() {
	int t;
	cin >> t;
	for (; t > 0; t--) {
		map<string, int> clothesMap;
		int n;
		cin >> n;
		string keys[30];
		int keyIndex = 0;

		for (; n > 0; n--) {
			string input;
			cin >> input;
			cin >> input;
			if (clothesMap.find(input) == clothesMap.end()) {
				keys[keyIndex++] = input;
				clothesMap.insert(make_pair(input, 0));
			}
			clothesMap[input]++;
		}

		int total = 0;
		for (int i = 0; i < keyIndex; i++)
			total = total == 0 ? clothesMap[keys[i]] + 1 : (clothesMap[keys[i]] + 1) * total;
		total = total == 0 ? total : total - 1;
		cout << total << endl;
	}
}