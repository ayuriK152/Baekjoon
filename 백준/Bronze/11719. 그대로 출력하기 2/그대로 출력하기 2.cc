#include <iostream>
#include <string>
#include <vector>

using namespace std;

int main() {
	vector<string> str;
	string input;

	while (true) {
		getline(cin, input);
		if (cin.eof())
			break;
		str.push_back(input);
	}

	for (int i = 0; i < str.size(); i++) {
		cout << str[i] << endl;
	}

	return 0;
}