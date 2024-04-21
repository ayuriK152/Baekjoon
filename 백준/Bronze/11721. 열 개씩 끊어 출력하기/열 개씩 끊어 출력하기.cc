#include <iostream>
#include <string>

using namespace std;

int main() {
	string input;
	getline(cin, input);
	for (int i = 0; i < input.size(); i++) {
		cout << input[i];
		if ((i + 1) % 10 == 0)
			cout << endl;
	}
	return 0;
}