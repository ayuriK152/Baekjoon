#include <iostream>
#include <string>
using namespace std;

int main() {
	int result = 0;
	int num = 0;
	bool isMinus = false;
	string input;
	cin >> input;
	for (int i = 0; i < input.size(); i++) {
		if (input[i] == '-') {
			if (!isMinus) {
				result += num;
				isMinus = true;
			}
			else {
				result -= num;
			}
			num = 0;
		}
		else if (input[i] == '+') {
			if (!isMinus)
				result += num;
			else
				result -= num;
			num = 0;
		}
		else {
			num *= 10;
			num += input[i] - '0';
		}
	}
	result = isMinus ? result - num : result + num;

	cout << result;

	return 0;
}