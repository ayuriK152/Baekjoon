#include <iostream>
#include <string>
using namespace std;

int main() {
	string doc;
	getline(cin, doc);
	string input;
	getline(cin, input);
	int info[50] = { 0 }, compIdx = 0;
	for (int i = 1; i < input.length(); i++) {
		if (input[i] == input[compIdx])
			info[i] = ++compIdx;
		else {
			info[i] = info[i - 1];
			compIdx = 0;
		}
	}
	compIdx = 0;
	int result = 0;
	for (int i = 0; i < doc.length(); i++) {
		if (doc[i] == input[compIdx])
			compIdx++;
		else
			compIdx = doc[i] == input[info[compIdx]] ? info[compIdx] + 1 : 0;
		if (compIdx == input.length()) {
			result++;
			compIdx = 0;
		}
	}
	cout << result;
	return 0;
}
